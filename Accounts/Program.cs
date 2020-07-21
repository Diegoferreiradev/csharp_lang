using Accounts.Entities;
using System;

namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Account acc1 = new BusinessAccount(456789, "Diego Ferreira", 3500.00, 0.20);
            Account acc2 = new SavingsAccount(521321, "Mariana Silva", 3200.00, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}
