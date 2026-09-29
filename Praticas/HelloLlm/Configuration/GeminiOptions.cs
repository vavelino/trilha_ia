using System.Text.Json;

namespace HelloLlm.Configuration;

public sealed class GeminiOptions
{
    public string ApiKey { get; }
    public string Model { get; }

    private GeminiOptions(string apiKey, string model)
    {
        ApiKey = apiKey;
        Model = model;
    }

    public static GeminiOptions Load()
    {
        string? localApiKey = null;
        string? localModel = null;
        var path = Path.Combine(AppContext.BaseDirectory, "appsettings.Local.json");
        if (File.Exists(path))
        {
            try
            {
                using var document = JsonDocument.Parse(File.ReadAllText(path));
                var gemini = document.RootElement.GetProperty("Gemini");
                if (gemini.TryGetProperty("ApiKey", out var key))
                    localApiKey = key.GetString();
                if (gemini.TryGetProperty("Model", out var modelValue))
                    localModel = modelValue.GetString();
            }
            catch (Exception exception) when (exception is JsonException
                or KeyNotFoundException or InvalidOperationException or IOException
                or UnauthorizedAccessException)
            {
                // Não incluir o conteúdo do arquivo na mensagem: ele contém a chave.
                throw new InvalidOperationException(
                    "Não foi possível ler appsettings.Local.json. Confira o JSON e a seção Gemini.");
            }
        }

        // Configuração local tem prioridade; ambiente serve como alternativa.
        var apiKey = !string.IsNullOrWhiteSpace(localApiKey)
            ? localApiKey
            : Environment.GetEnvironmentVariable("GEMINI_API_KEY");

        if (string.IsNullOrWhiteSpace(apiKey))
        {
            throw new InvalidOperationException(
                "Configure Gemini:ApiKey em appsettings.Local.json ou a variável GEMINI_API_KEY.");
        }

        var model = !string.IsNullOrWhiteSpace(localModel)
            ? localModel
            : Environment.GetEnvironmentVariable("GEMINI_MODEL");

        if (string.IsNullOrWhiteSpace(model))
        {
            model = "gemini-3.5-flash-lite";
        }
        return new GeminiOptions(apiKey, model);
    }
}
