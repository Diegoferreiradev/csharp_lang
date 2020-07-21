using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Produto
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }


        public Produto()
        {

        }

        public Produto(string nome, double preco): this()
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int item)
        {
            Quantidade += item;
        }

        public void RemoverProdutos(int item)
        {
            Quantidade -= item;
        }

        public override string ToString()
        {
            return $"{Nome}, " +
                   $" R$ {Preco}, " +
                   $"{Quantidade} unidades, " +
                   $"Total R$: {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
   