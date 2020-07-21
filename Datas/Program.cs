using System;
using System.Globalization;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime data = DateTime.Now;

            //Console.WriteLine(data);
            //Console.WriteLine(data.Ticks);
            //Console.WriteLine(data.Day);
            //Console.WriteLine(data.Month);
            //Console.WriteLine(data.Year);
            //Console.WriteLine(data.Hour);
            //Console.WriteLine(data.Minute);
            //Console.WriteLine(data.Second);
            //Console.WriteLine(data.Millisecond);
            //Console.WriteLine(data.DayOfWeek);
            //Console.WriteLine(data.DayOfYear);
            //Console.WriteLine(data.Date);

            DateTime d1 = new DateTime(2020, 07, 03);

            DateTime d2 = DateTime.Parse("03/07/2020");

            DateTime d3 = DateTime.Parse("03/07/2020 11:20:03");

            DateTime d4 = DateTime.ParseExact("2020-07-03", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            DateTime d5 = DateTime.ParseExact("03/07/2020 11:27:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
        }
    }
}
