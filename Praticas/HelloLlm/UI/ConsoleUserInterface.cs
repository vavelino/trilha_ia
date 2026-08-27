namespace HelloLlm.UI;

public sealed class ConsoleUserInterface
{
    public void ShowWelcome()
    {
        Console.WriteLine("Hello LLM");
        Console.WriteLine("Digite uma pergunta ou 'sair' para encerrar.");
        Console.WriteLine();
    }

    public string? ReadQuestion()
    {
        while (true)
        {
            Console.Write("Pergunta: ");

            var input = Console.ReadLine();

            if (input is null || input.Equals("sair", StringComparison.OrdinalIgnoreCase))
            {
                return null;
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("A pergunta não pode estar vazia.");
                continue;
            }

            return input.Trim();
        }
    }

    public void ShowWaitingForResponse()
    {
        Console.WriteLine("Consultando o modelo...");
    }

    public void ShowAnswer(string answer, TimeSpan elapsed)
    {
        Console.WriteLine();
        Console.WriteLine("Resposta:");
        Console.WriteLine(answer);
        Console.WriteLine();
        Console.WriteLine($"Tempo da requisição: {elapsed.TotalSeconds:F2} s");
        Console.WriteLine();
    }

    public void ShowError(string message)
    {
        Console.WriteLine();
        Console.WriteLine($"Erro: {message}");
        Console.WriteLine();
    }

    public void ShowGoodbye()
    {
        Console.WriteLine("Aplicação encerrada.");
    }
}
