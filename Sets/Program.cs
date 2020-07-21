using System;
using System.Collections.Generic;

namespace Sets01
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("SmartPhone");
            set.Add("SmartWatch");
            set.Add("HeadPhone");
            set.Add("Notebook");
            set.Add("Beer");
            set.Add("Bike");

            //set.Remove("Beer");

            foreach (string item in set)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(set.Contains("Beer"));

        }
    }
}
