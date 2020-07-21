using System;

namespace Devices.Entities
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine($"Scanner Processing {doc}");
        }

        public string Scan()
        {
            return "Scanner Scan result";
        }
    }
}
