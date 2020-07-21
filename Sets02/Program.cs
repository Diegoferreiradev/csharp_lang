using System;
using System.Collections.Generic;

namespace Sets02
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> seq01 = new SortedSet<int>() { 0, 2, 5, 8, 10, 15, 20 };
            SortedSet<int> seq02 = new SortedSet<int>() { 5, 15, 2, 8, 3, 7, 9 };

            SortedSet<int> seq03 = new SortedSet<int>(seq01);
            seq03.UnionWith(seq02);

            PrintCollection(seq03);
        }


        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }

            Console.WriteLine();
        }
    }
}
