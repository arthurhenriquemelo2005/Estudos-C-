using System;

    class Cadastro
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual o nome do usuário: ");
        string LoginUser = Console.ReadLine() ??"";

        if(LoginUser == "")
        {
            Console.WriteLine("Erro");
        }

        Console.WriteLine("Informe sua idade: ");
        int Idade = int.Parse(Console.ReadLine() ?? "");

        if(Idade <= 0)
        {
            Console.WriteLine("Idade inválida");
        }

        Console.WriteLine("Digite seu Email: ");
        string Email = Console.ReadLine()?? "";

        if (!Email.Contains("@"))
        {
            Console.WriteLine("Acesso Negado ! (O email não possui @)");
        }

        Console.Clear();

        Console.WriteLine(" === DADOS CADASTRADOS ===");
        Console.WriteLine($"Nome: {LoginUser}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Email: {Email}");

        
    }
}