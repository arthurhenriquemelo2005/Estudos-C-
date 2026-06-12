using System;

class Lanchonete
{
    static void Main(string[] args)
    {
        decimal precoHamburger = 21;
        decimal precoBatata = 6;
        decimal precoRefrigerante = 7;

        bool loop = true;

        while (loop)
        {
            Console.WriteLine("[1] Hambúrguer");
            Console.WriteLine("[2] Batata");
            Console.WriteLine("[3] Refrigerante");
            Console.WriteLine("[4] Sair");

            Console.WriteLine("O que voce vai querer: ");
            int escolha = int.Parse(Console.ReadLine() ?? "");

            if (escolha <= 0 || escolha > 4)
            {
                Console.WriteLine("Escolha invalida: escolha entre 1 e 4");
            }

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Quantos hamburguers você vai querer: ");
                    int quantidadeHamburguer = int.Parse(Console.ReadLine() ?? "");

                    if (quantidadeHamburguer <= 0)
                    {
                        Console.WriteLine("Quantidade inválida");
                    }
                    else
                    {
                        decimal total = precoHamburger * quantidadeHamburguer;

                        Console.WriteLine($"Você pediu {quantidadeHamburguer} hamburguers e o preço ficou R${total:F2}");
                    }
                    break;

                case 2:
                    Console.WriteLine("Quantas batatas você vai querer: ");
                    int quantidadeBatata = int.Parse(Console.ReadLine() ?? "");

                    if (quantidadeBatata <= 0)
                    {
                        Console.WriteLine("Quantidade inválida");
                    }
                    else
                    {
                        decimal total = precoBatata * quantidadeBatata;

                        Console.WriteLine($"Você pediu {quantidadeBatata} batatas e o preço ficou R${total:F2}");
                    }
                    break;

                case 3:
                    Console.WriteLine("Quantos refrigerantes você vai querer: ");
                    int quantidadeRefrigerante = int.Parse(Console.ReadLine() ?? "");

                    if (quantidadeRefrigerante <= 0)
                    {
                        Console.WriteLine("Quantidade inválida");
                    }
                    else
                    {
                        decimal total = precoRefrigerante * quantidadeRefrigerante;

                        Console.WriteLine($"Você pediu {quantidadeRefrigerante} refrigerantes e o preço ficou R${total:F2}");
                    }
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Saindo...");
                    loop = false;
                    break;
            }

            Console.WriteLine();
        }
    }
}