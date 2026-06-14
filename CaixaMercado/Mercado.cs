using System;
    
    class Mercado
{
    static void Main(string[] args)
    {
       
            decimal valorTotal = 0;

            Console.WriteLine("Nome do produto: ");
            string nomeProduto = (Console.ReadLine()??"").ToLower();

            Console.WriteLine("Preço: ");
            decimal precoProduto = decimal.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Quantidade: ");
            int quantidadeProduto = int.Parse(Console.ReadLine() ??"");

            Console.WriteLine("digite (sair) para sair do sistema");

            valorTotal += precoProduto * quantidadeProduto;
           
            Console.Clear();

            Console.WriteLine("=== COMPROVANTE DE VENDA ====");
            Console.WriteLine($"Produto: {nomeProduto}");
            Console.WriteLine($"Preço do produto: {precoProduto}");
            Console.WriteLine($"{quantidadeProduto} unidades");
            Console.WriteLine($"Preco total: {valorTotal}");
            
    }
}