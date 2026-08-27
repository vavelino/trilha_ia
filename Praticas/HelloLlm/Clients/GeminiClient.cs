using System.Net.Http.Json;
using System.Text.Json;
using HelloLlm.Configuration;

namespace HelloLlm.Clients;

public sealed class GeminiClient : ILlmClient
{
    private readonly HttpClient _httpClient;
    private readonly GeminiOptions _options;

    public GeminiClient(HttpClient httpClient, GeminiOptions options)
    {
        _httpClient = httpClient;
        _options = options;
    }

    public async Task<string> AskAsync(
        string question,
        CancellationToken cancellationToken = default)
    {
        const int maxAttempts = 3;

        for (var attempt = 1; attempt <= maxAttempts; attempt++)
        {
            try
            {
                return await SendAsync(question, cancellationToken);
            }
            catch (HttpRequestException exception)
                when (attempt < maxAttempts && IsTransient(exception.StatusCode))
            {
                var delay = TimeSpan.FromSeconds(Math.Pow(2, attempt - 1));
                await Task.Delay(delay, cancellationToken);
            }
        }

        throw new InvalidOperationException("Não foi possível consultar o Gemini.");
    }

    private async Task<string> SendAsync(
        string question,
        CancellationToken cancellationToken)
    {
        var path = $"v1beta/models/{Uri.EscapeDataString(_options.Model)}:generateContent";
        var body = new GenerateContentRequest(
            [new Content([new Part(question)])]);

        using var request = new HttpRequestMessage(HttpMethod.Post, path);
        request.Headers.Add("x-goog-api-key", _options.ApiKey);
        request.Content = JsonContent.Create(body);

        using var response = await _httpClient.SendAsync(request, cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var errorBody = await response.Content.ReadAsStringAsync(cancellationToken);
            var message = ReadErrorMessage(errorBody) ?? response.ReasonPhrase;

            throw new HttpRequestException(
                $"Gemini retornou HTTP {(int)response.StatusCode}: {message}",
                inner: null,
                response.StatusCode);
        }

        var result = await response.Content.ReadFromJsonAsync<GenerateContentResponse>(
            cancellationToken: cancellationToken);

        var answer = result?.Candidates?
            .FirstOrDefault()?
            .Content?
            .Parts?
            .Select(part => part.Text)
            .FirstOrDefault(text => !string.IsNullOrWhiteSpace(text));

        return answer
            ?? throw new InvalidOperationException("O Gemini não retornou uma resposta textual.");
    }

    private static bool IsTransient(System.Net.HttpStatusCode? statusCode)
    {
        return statusCode is null
            or System.Net.HttpStatusCode.TooManyRequests
            or System.Net.HttpStatusCode.InternalServerError
            or System.Net.HttpStatusCode.BadGateway
            or System.Net.HttpStatusCode.ServiceUnavailable
            or System.Net.HttpStatusCode.GatewayTimeout;
    }

    private static string? ReadErrorMessage(string errorBody)
    {
        try
        {
            using var document = JsonDocument.Parse(errorBody);
            return document.RootElement
                .GetProperty("error")
                .GetProperty("message")
                .GetString();
        }
        catch (JsonException)
        {
            return null;
        }
        catch (InvalidOperationException)
        {
            return null;
        }
        catch (KeyNotFoundException)
        {
            return null;
        }
    }

    private sealed record GenerateContentRequest(IReadOnlyList<Content> Contents);
    private sealed record Content(IReadOnlyList<Part> Parts);
    private sealed record Part(string Text);
    private sealed record GenerateContentResponse(IReadOnlyList<Candidate>? Candidates);
    private sealed record Candidate(Content? Content);
}
