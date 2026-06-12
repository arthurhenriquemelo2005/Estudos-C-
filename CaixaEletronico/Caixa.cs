using System;

class Caixa
{
    static void Main(string[] args)
    {

        decimal saldo = 1000;
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("[1] Ver saldo");
            Console.WriteLine("[2] Depositar");
            Console.WriteLine("[3] Sacar");
            Console.WriteLine("[4] Sair");

            Console.WriteLine("Escolha uma das opções: ");
            int opcao = int.Parse(Console.ReadLine() ?? "");

            if (opcao <= 0 || opcao > 4)
            {
                Console.WriteLine("Escolha inválida");
                continue;
            }

            switch (opcao)
            {
                case 1:

                    Console.Clear();
                    Console.WriteLine($"Saldo atual R${saldo:F2}");
                    break;

                case 2:

                    Console.Clear();
                    Console.WriteLine("Qual valor do deposito: ");
                    decimal deposito = decimal.Parse(Console.ReadLine() ?? "");

                    if (deposito <= 0)
                    {
                        Console.WriteLine("Deposito inválido");
                    }
                    else
                    {
                        saldo += deposito;
                        Console.WriteLine($"Deposito realizado novo saldo de R${saldo:F2}");
                    }
                    break;

                case 3:

                    Console.Clear();
                    Console.WriteLine("Qual o valor do saque: ");
                    decimal saque =    decimal.Parse(Console.ReadLine() ?? "");
                    
                    if(saque > saldo)
                    {
                        Console.WriteLine("Saque inválido");
                    }else{
                    saldo -= saque;

                    Console.WriteLine($"Saque Realizado novo saldo de R${saldo:F2}");
                    }
                    break;
                
                case 4:
                    
                    Console.Clear();
                    Console.WriteLine("Saindo...");
                    loop = false;
                    break;


            }
        }
    }
}