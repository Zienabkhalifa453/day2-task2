﻿using System;
using System.Collections.Generic;
namespace ConsoleApp2
{
    class program
    {
        static void Main(string[] args)
        {
            var f = new List<String>();
            while (true)
            {
                Console.WriteLine("Write name:");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                else
                    f.Add(input);
            }
            switch (f.Count)
            {
                case 0:
                    Console.WriteLine("Nobody likes your post");
            break;
                case 1:
                    Console.WriteLine("{0} likes your post", f[0]);
            break;
                case 2:
                    Console.WriteLine("{0} and {1} liked your post", f[0], f[1]);
            break;
                default:
                    Console.WriteLine("{0} and {1} and { 2}other people liked your post", f[0],f[1], (f.Count - 2));
                    break;
            }

        }
    }
}