using System.Text.Json;

namespace HelloLlm.Models;

public static class TaskAnalysisParser
{
    public static TaskAnalysis Parse(string json)
    {
        using var document = JsonDocument.Parse(json);
        var root = document.RootElement;
        if (root.ValueKind != JsonValueKind.Object)
            throw new InvalidOperationException("A resposta deve ser um objeto JSON.");

        string[] fields = ["summary", "technicalTasks", "risks", "questions"];
        var seen = new HashSet<string>();
        foreach (var property in root.EnumerateObject())
        {
            if (!fields.Contains(property.Name) || !seen.Add(property.Name))
                throw new InvalidOperationException($"Campo inesperado ou duplicado: {property.Name}.");
        }

        foreach (var field in fields)
        {
            if (!root.TryGetProperty(field, out var value))
                throw new InvalidOperationException($"Campo obrigatório ausente: {field}.");

            if (field == "summary")
            {
                if (value.ValueKind != JsonValueKind.String || string.IsNullOrWhiteSpace(value.GetString()))
                    throw new InvalidOperationException("A análise precisa ter um resumo não vazio.");
                continue;
            }

            if (value.ValueKind != JsonValueKind.Array)
                throw new InvalidOperationException($"{field} deve ser uma lista.");
            if (field == "technicalTasks" && value.GetArrayLength() == 0)
                throw new InvalidOperationException("A análise precisa ter pelo menos uma atividade técnica.");
            foreach (var item in value.EnumerateArray())
            {
                if (item.ValueKind != JsonValueKind.String || string.IsNullOrWhiteSpace(item.GetString()))
                    throw new InvalidOperationException($"{field} deve conter somente textos não vazios.");
            }
        }

        return JsonSerializer.Deserialize<TaskAnalysis>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
    }
}
