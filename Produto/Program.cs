 using System;
using System.Globalization;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Informe os dados do Produto: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade no Estoque: ");
            int quantidade = int.Parse(Console.ReadLine());


            Produto p = new Produto(nome, preco, quantidade);

            //Produto produto = new Produto
            //{
            //    Nome = "Relógio",
            //    Preco = 1899.00,
            //    Quantidade = 1
            //};

            
            Console.WriteLine($"Dados Atualizados: {p}");

            Console.WriteLine("Digite o número de Produtos a ser adicionado ao Estoque: ");
            int item = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(item);

            Console.WriteLine($"Dados Atualizados: {p}");

            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            item = int.Parse(Console.ReadLine());
            p.RemoverProdutos(item);

            Console.WriteLine($"Dados Atualizados: {p}");

            //Console.WriteLine(produto);

        }
    }
}
