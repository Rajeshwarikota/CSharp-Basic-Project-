﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Csharp Basic Project");
            
            Console.WriteLine("please enter the first number");
            int first=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            int second = Convert.ToInt32(Console.ReadLine());

            Calculator Calculator1 = new Calculator(first,second);
            Calculator1.Addition();
            Calculator1.substraction();


            Console.WriteLine("please enter the first number");
            int third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            int fourth = Convert.ToInt32(Console.ReadLine());

            Calculator Calculator2 = new Calculator(third,fourth);
            Calculator2.Addition();
            Calculator2.substraction();
            Console.ReadLine();
        }
    }
}
