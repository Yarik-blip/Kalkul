﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int a = Convert.ToInt32(Console.ReadLine());
            string c = Console.ReadLine();
            int b = Convert.ToInt32(Console.ReadLine());
            if (c == "+")
            {
                Console.WriteLine("=");
                Console.WriteLine(a + b);
                Console.ReadKey();
            }
            if (c == "-")
            {
                Console.WriteLine("=");
                Console.WriteLine(a - b);
                Console.ReadKey();
            }
            if (c == "*")
            {
                Console.WriteLine("=");
                Console.WriteLine(a * b);
                Console.ReadKey();
            }
            if (c == "/")
            {
                Console.WriteLine("=");
                Console.WriteLine(a / b);
                Console.ReadKey();
            }
           
                   
        }
    }
}
