﻿using System;
using SocialNetwork.Entities;

namespace SocialNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");
            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");


            Post p1 = new Post( 
                DateTime.Parse("01/07/2020"), 
                "Traveling to New Zealand", 
                "I'm going to visit this wonderful country!", 
                12
             );
            p1.AddComment(c1);
            p1.AddComment(c2);
   

            Post p2 = new Post(
                DateTime.Parse("04/07/2020"), 
                "Good night guys", 
                "See you tomorrow", 
                5
            );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
