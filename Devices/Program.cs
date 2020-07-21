using System;
using Devices.Entities;

namespace Devices
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer() { SerialNumber = 1099 };
            printer.ProcessDoc("My letter");
            printer.Print("My letter");


            Scanner scanner = new Scanner() { SerialNumber = 1357 };
            scanner.ProcessDoc("My email");
            Console.WriteLine(scanner.Scan());

            ComboDevice combo = new ComboDevice() { SerialNumber = 5217 };
            combo.ProcessDoc("My dissertation");
            combo.Print("My dissertation");
            Console.WriteLine(combo.Scan());
        }
    }
}
