using System;

    class Cadastro
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual o nome do usuário: ");
        string loginUser = Console.ReadLine() ??"";

        if(loginUser == "")
        {
            Console.WriteLine("Erro");
        }

        Console.WriteLine("Informe sua idade: ");
        int idade = int.Parse(Console.ReadLine() ?? "");

        if(idade <= 0)
        {
            Console.WriteLine("Idade inválida");
        }

        Console.WriteLine("Digite seu Email: ");
        string email = Console.ReadLine()?? "";

        if (!email.Contains("@"))
        {
            Console.WriteLine("Acesso Negado ! (O email não possui @)");
        }

        Console.Clear();

        Console.WriteLine(" === DADOS CADASTRADOS ===");
        Console.WriteLine($"Nome: {loginUser}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Email: {email}");

        
    }
}
