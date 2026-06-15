using System;

class Locadora
{
    static void Main(string[] args)
    {
        decimal valorAluguel = 130;
        decimal precoFinal = 0;
        int dias = 0;
        string nomeCliente = "";
        string modeloCliente = "";
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("[1] Alugar Carro");
            Console.WriteLine("[2] Devolver Carro");
            Console.WriteLine("[3] Consultar Aluguel");
            Console.WriteLine("[4] Sair");

            Console.WriteLine("Escolha uma das opções: ");
            int escolha = int.Parse(Console.ReadLine() ?? "");

            switch (escolha)
            {
                case 1:

                    Console.Clear();

                    Console.WriteLine("Informe seu nome: ");
                    string nomeUser = (Console.ReadLine() ?? "").ToLower();
                    nomeCliente += nomeUser;

                    Console.WriteLine("Qual modelo do carro: ");
                    string modeloCarro = (Console.ReadLine() ?? "").ToLower();
                    modeloCliente += modeloCarro;

                    Console.WriteLine($"O aluguel diario é {valorAluguel} ");
                    Console.WriteLine("Quantos dias com o carro alugado: ");
                    int diasAlugados = int.Parse(Console.ReadLine() ?? "");

                    if(diasAlugados <= 0)
                    {
                        Console.WriteLine("Quantidade inválida");
                    }else{

                    dias += diasAlugados;
                    precoFinal += valorAluguel * diasAlugados;}
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine($"O preço total ficou de {precoFinal}");
                    break;
                
                case 3:

                    Console.Clear();
                    Console.WriteLine("=== Dados ===");
                    Console.WriteLine($"Nome: {nomeCliente}");
                    Console.WriteLine($"Modelo: {modeloCliente}");
                    Console.WriteLine($"Dias: {dias}");
                    Console.WriteLine($"Preoço Final: {precoFinal}");
                    break;
                
                case 4:

                    Console.WriteLine("Saindo...");
                    loop = false;
                    break;
                    
                default:

                    Console.WriteLine("Escolha inválida");
                    break;
            }
        }
    }
}
