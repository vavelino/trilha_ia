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

    public static GeminiOptions FromEnvironment()
    {
        var apiKey = Environment.GetEnvironmentVariable("GEMINI_API_KEY");

        if (string.IsNullOrWhiteSpace(apiKey))
        {
            throw new InvalidOperationException(
                "A variável de ambiente GEMINI_API_KEY não foi configurada.");
        }

        var model = Environment.GetEnvironmentVariable("GEMINI_MODEL");

        if (string.IsNullOrWhiteSpace(model))
        {
            model = "gemini-3.5-flash-lite";
        }
        return new GeminiOptions(apiKey, model);
    }
}
