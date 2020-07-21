using System;

namespace TimeSpan1
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(11, 47, 00);
            TimeSpan t2 = new TimeSpan(3, 1, 10, 15);
            TimeSpan t3 = new TimeSpan(900000000L);

            TimeSpan t4 = TimeSpan.FromDays(1.5);
            TimeSpan t5 = TimeSpan.FromHours(1.5);
            TimeSpan t6 = TimeSpan.FromMinutes(1.5);
            TimeSpan t7 = TimeSpan.FromSeconds(1.5);
            TimeSpan t8 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t9 = TimeSpan.FromTicks(900000000L);


            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
        }
    }
}
