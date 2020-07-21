using System;
using System.Globalization;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do Primeiro Funcionário");
            f1.nome = Console.ReadLine();
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Segundo Funcionário");
            f2.nome = Console.ReadLine();
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.salario + f2.salario) / 2;

            Console.WriteLine("Salário Médio: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
