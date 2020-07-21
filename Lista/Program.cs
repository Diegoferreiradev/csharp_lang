using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Smartphone");
            list.Add("HeadPhone");
            list.Add("Relógio");
            list.Add("Ar Condicionado");
            list.Add("Smart TV");
            list.Add("Garrafa");
            list.Add("TV");
            list.Add("Chaves");

            list.Insert(5, "Livro de C#");

            foreach (var item in list)
            {
                Console.WriteLine(item);               
            }

            Console.WriteLine($"Tamanho da lista:  {list.Count} items");
        }
    }
}
