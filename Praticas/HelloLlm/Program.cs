using System.Diagnostics;
using HelloLlm.Clients;
using HelloLlm.Configuration;
using HelloLlm.UI;

var console = new ConsoleUserInterface();

GeminiOptions options;

try
{
    options = GeminiOptions.FromEnvironment();
}
catch (InvalidOperationException exception)
{
    console.ShowError(exception.Message);
    return;
}

using var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://generativelanguage.googleapis.com/"),
    Timeout = TimeSpan.FromSeconds(60)
};

ILlmClient llmClient = new GeminiClient(httpClient, options);

console.ShowWelcome();

while (true)
{
    var question = console.ReadQuestion();

    if (question is null)
    {
        break;
    }

    console.ShowWaitingForResponse();
    var stopwatch = Stopwatch.StartNew();

    try
    {
        var answer = await llmClient.AskAsync(question);
        stopwatch.Stop();
        console.ShowAnswer(answer, stopwatch.Elapsed);
    }
    catch (TaskCanceledException)
    {
        stopwatch.Stop();
        console.ShowError("A requisição excedeu o limite de 60 segundos.");
    }
    catch (HttpRequestException exception)
    {
        stopwatch.Stop();
        console.ShowError(exception.Message);
    }
    catch (InvalidOperationException exception)
    {
        stopwatch.Stop();
        console.ShowError(exception.Message);
    }
}

console.ShowGoodbye();
