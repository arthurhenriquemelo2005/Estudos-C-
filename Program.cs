using System;
using System.Runtime.InteropServices;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        bool lopLigado = true;
        while (lopLigado)
        {
            Console.WriteLine(" === CALCULADORA === ");

            Console.WriteLine("[1] Soma");
            Console.WriteLine("[2] Subtrair");
            Console.WriteLine("[3] Multiplicar");
            Console.WriteLine("[4] Dividir");
            Console.WriteLine("[5] Sair");

            Console.WriteLine("Escolha uma das opções: ");
            int opcao = int.Parse(Console.ReadLine() ?? "");


            switch (opcao)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine(" === SOMA ===");
                    Console.WriteLine("Informe o primeiro número: ");
                    float number1 = float.Parse(Console.ReadLine() ?? "");
                    Console.WriteLine("Informe o segundo número: ");
                    float number2 = float.Parse(Console.ReadLine() ?? "");

                    float soma = number1 + number2;

                    Console.WriteLine($"Resultado: {soma}");
                    break;

                case 2:
                    Console.Clear();

                    Console.WriteLine("=== SUBTRAÇÃO ===");
                    Console.WriteLine("Informe o primeiro número: ");
                    float subN1 = float.Parse(Console.ReadLine() ?? "");
                    Console.WriteLine("Informe o segundo número: ");
                    float subN2 = float.Parse(Console.ReadLine() ?? "");

                    float subtracao = subN1 - subN2;

                    Console.WriteLine($"Resultado: {subtracao}");
                    break;

                case 3:
                    Console.Clear();

                    Console.WriteLine(" === MULTIPLICAÇÃO ===");
                    Console.WriteLine("Informe o primeiro número: ");
                    float multN1 = float.Parse(Console.ReadLine() ?? "");
                    Console.WriteLine("Informe o segundo número: ");
                    float multN2 = float.Parse(Console.ReadLine() ?? "");

                    float multiplicacao = multN1 * multN2;

                    Console.WriteLine($"Resultado: {multiplicacao}");
                    break;

                case 4:
                    Console.Clear();

                    Console.WriteLine(" === DIVISÃO ===");
                    Console.WriteLine("Informe o primeiro número: ");
                    float divN1 = float.Parse(Console.ReadLine() ?? "");
                    Console.WriteLine("Informe o segundo número: ");
                    float divN2 = float.Parse(Console.ReadLine() ?? "");



                    if (divN2 != 0)
                    {
                        float divisao = divN1 / divN2;
                        Console.WriteLine($"Resultado: {divisao}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: não é possivel dividir por 0");
                    }
                    break;

                case 5:
                    Console.Clear();

                    Console.WriteLine("Saindo...");
                    lopLigado = false ;
                    break;

                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
        }
    }
}