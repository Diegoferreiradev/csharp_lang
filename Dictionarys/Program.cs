using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Diego";
            cookies["email"] = "diegotestes@gmail.com";
            cookies["phone"] = "7777-8888";
            cookies["phone"] = "3333-9999";


            Console.WriteLine(cookies["phone"]);
            Console.WriteLine(cookies["email"]);

            //cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'Email' key!");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("All Cookies: ");

            //foreach (KeyValuePair<string, string> item in cookies)  Verboso demais!
            //{
            //    Console.WriteLine(item.Key + " : " + item.Value);
            //}

            foreach (var item in cookies)
            {
                Console.WriteLine(item);
            }
        }
    }
}
