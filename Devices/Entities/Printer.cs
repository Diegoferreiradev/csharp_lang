using System;

namespace Devices.Entities
{
    class Printer : Device, IPrinter
    {

        public override void ProcessDoc(string doc)
        {
            Console.WriteLine($"Printe processing: {doc}");
        }

        public void Print(string doc)
        {
            Console.WriteLine($"Printer print: {doc}");
        }
    }
}
