namespace HelloLlm.Clients;

public interface ILlmClient
{
    Task<string> AskAsync(
        string question,
        CancellationToken cancellationToken = default);
}
