using System;
using System.Globalization;

namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre com o Número da Conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o Titular da Conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial (s/n): ");
            char status = char.Parse(Console.ReadLine());

            if (status == 's' || status == 'S')
            {
                Console.Write("Informe o Valor para o Depósito: ");
                double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, titular, valorDeposito);
            }
            else
            {
                conta = new Conta(numero, titular);
            }

            Console.WriteLine(conta);

            Console.Write("Entre com um valor para o Depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valor);

            Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(conta);

            Console.Write("Entre com um valor para Saque: ");
             valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);

            Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(conta);
        }
        
    }
}
