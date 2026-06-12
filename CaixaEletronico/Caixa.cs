using System;

class Caixa
{
    static void Main(string[] args)
    {

        //Definindo valor do saldo
        decimal saldo = 1000;
        bool loop = true; // Enquanto o loop for true(veradadeiro) ele segue
        while (loop)
        {
            //Menu de escolhas do usuário
            Console.WriteLine("[1] Ver saldo");
            Console.WriteLine("[2] Depositar");
            Console.WriteLine("[3] Sacar");
            Console.WriteLine("[4] Sair");

            Console.WriteLine("Escolha uma das opções: ");
            int opcao = int.Parse(Console.ReadLine() ?? "");
            
            //Validação das entradas
            if (opcao <= 0 || opcao > 4)
            {
                Console.WriteLine("Escolha inválida");
                continue;
            }
            //Escolhas dos usuários
            switch (opcao)
            {
                case 1:
                    //Limpa a tela
                    Console.Clear();
                    Console.WriteLine($"Saldo atual R${saldo:F2}");
                    break;

                case 2:
                    //Limpa a tela 
                    Console.Clear();
                    Console.WriteLine("Qual valor do deposito: ");
                    decimal deposito = decimal.Parse(Console.ReadLine() ?? "");
                    
                    //Validação do deposito
                    if (deposito <= 0)
                    {
                        Console.WriteLine("Deposito inválido");
                    }
                    else
                    {
                        //Atribuindo o deposito ao saldo (saldo recebe o deposito feito pelo usuário)
                        saldo += deposito;
                        Console.WriteLine($"Deposito realizado novo saldo de R${saldo:F2}");
                    }
                    break;

                case 3:
                    //Limpa a tela
                    Console.Clear();
                    Console.WriteLine("Qual o valor do saque: ");
                    decimal saque = decimal.Parse(Console.ReadLine() ?? "");

                    //Validação do saque
                    if(saque > saldo)
                    {
                        Console.WriteLine("Saque inválido");
                    }else{
                    //Atribuindo saque ao saldo (saldo recebe saque feito pelo usuário)
                    saldo -= saque;

                    Console.WriteLine($"Saque Realizado novo saldo de R${saldo:F2}");
                    }
                    break;
                
                case 4:
                    //Saindo do caixa
                    Console.Clear();
                    Console.WriteLine("Saindo...");
                    loop = false; // Loop como falso para encerrar o loop
                    break;


            }
        }
    }
}
