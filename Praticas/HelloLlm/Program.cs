using System.Diagnostics;
using System.Text.Json;
using HelloLlm.Clients;
using HelloLlm.Configuration;
using HelloLlm.Models;
using HelloLlm.UI;

var console = new ConsoleUserInterface();

if (args.Contains("--test-json"))
{
    var answer = """
    {
      "summary": "Impedir CPF duplicado",
      "technicalTasks": ["Normalizar o CPF"],
      "risks": ["Cadastros simultâneos"],
      "questions": ["Qual status HTTP retornar?"]
    }
    """;
    // Preserva o caso de resumo vazio do exercício anterior.
    if (args.Contains("--invalid-summary"))
        answer = answer.Replace("Impedir CPF duplicado", "");

    try
    {
        var analysis = TaskAnalysisParser.Parse(answer);
        Console.WriteLine("Teste local de desserialização e validação (sem API)");
        Console.WriteLine($"Resumo: {analysis.Summary}");
        foreach (var task in analysis.TechnicalTasks)
            Console.WriteLine($"Atividade: {task}");
        foreach (var risk in analysis.Risks)
            Console.WriteLine($"Risco: {risk}");
        foreach (var question in analysis.Questions)
            Console.WriteLine($"Pergunta: {question}");
    }
    catch (Exception exception) when (exception is JsonException or InvalidOperationException)
    {
        console.ShowError(exception.Message);
        Environment.ExitCode = 1;
    }
    return;
}

var analyzeTask = args.Contains("--analyze-task");
string? promptTemplate = null;
if (analyzeTask)
{
    promptTemplate = await File.ReadAllTextAsync(
        Path.Combine(AppContext.BaseDirectory, "Prompts", "analisar-tarefa.md"));
    Console.WriteLine("Modo análise: descreva uma tarefa para receber JSON validado.");
}

GeminiOptions options;
try
{
    options = GeminiOptions.Load();
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
        break;

    console.ShowWaitingForResponse();
    var stopwatch = Stopwatch.StartNew();
    try
    {
        var prompt = analyzeTask
            ? promptTemplate!.Replace("{{descricaoDaTarefa}}", question)
            : question;
        var answer = await llmClient.AskAsync(prompt);
        stopwatch.Stop();
        // A resposta original fica visível para avaliar a qualidade e investigar falhas.
        console.ShowAnswer(answer, stopwatch.Elapsed);
        if (analyzeTask)
        {
            var analysis = TaskAnalysisParser.Parse(answer);
            Console.WriteLine($"Contrato validado: {analysis.TechnicalTasks.Count} atividades, " +
                $"{analysis.Risks.Count} riscos e {analysis.Questions.Count} perguntas.");
        }
    }
    catch (JsonException exception)
    {
        console.ShowError($"Resposta JSON inválida: {exception.Message}");
    }
    catch (TaskCanceledException)
    {
        console.ShowError("A requisição excedeu o limite de 60 segundos.");
    }
    catch (HttpRequestException exception)
    {
        console.ShowError(exception.Message);
    }
    catch (InvalidOperationException exception)
    {
        console.ShowError(exception.Message);
    }
}
console.ShowGoodbye();
