﻿using System;
using System.Collections.Generic;
namespace ConsoleApp2
{
    class program
    {
        static void Main(string[] args)
        {
            int n, factor = 1, num;
            Console.Write("Enter numbers");
            string s = Console.ReadLine();
            bool integer = int.TryParse(s, out num);
            if (integer == true)
            {
                for (n= 1; n<= num; n++)
                {
                    factor = factor * n;
                }
            }
            else
            {
                Console.WriteLine("try again");
            }

            Console.Write(num+ "! = " + factor);





        }
    }
}