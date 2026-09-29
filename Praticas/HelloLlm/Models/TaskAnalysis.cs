namespace HelloLlm.Models;

public sealed class TaskAnalysis
{
    public string Summary { get; set; } = string.Empty;

    public List<string> TechnicalTasks { get; set; } = [];

    public List<string> Risks { get; set; } = [];

    public List<string> Questions { get; set; } = [];
}
