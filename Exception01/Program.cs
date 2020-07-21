using System;

namespace Exception01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Informe o 1º Número: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Informe o 2º Número: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by Zero is not allowed!");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format Error! {e.Message}");
            }
        }
    }
}
