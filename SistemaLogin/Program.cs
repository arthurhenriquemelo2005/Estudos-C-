using System;

    class Prgram
{
    static void Main(string [] args)
    {
        const string login = "Arthur";
        const string senha = "1234";

        Console.WriteLine("Qual o login do usuário: ");
        string loginUser = Console.ReadLine() ?? "";

        Console.WriteLine("Informe sua senha: ");
        string senhaUser = Console.ReadLine() ?? "";

        if(loginUser == login && senhaUser == senha)
        {
            Console.WriteLine("Acessso liberado");
        }
        else
        {
            Console.WriteLine("Acesso Negado");
        }
    }
}