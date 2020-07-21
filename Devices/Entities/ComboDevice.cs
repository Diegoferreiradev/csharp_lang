using System;

namespace Devices.Entities
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string doc)
        {
            Console.WriteLine($"Combo device print: {doc}");
        }

        public override void ProcessDoc(string doc)
        {
            Console.WriteLine($"ComboDevice processing: {doc}");
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}
