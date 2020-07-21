using System;
using System.Linq;
  

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 3, 4, 5 };

            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
