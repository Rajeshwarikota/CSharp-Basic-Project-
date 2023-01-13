using System;
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

            /// Console.WriteLine("please enter the first number");
            ///int first=Convert.ToInt32(Console.ReadLine());
            ///Console.WriteLine("please enter the second number");
            ///int second = Convert.ToInt32(Console.ReadLine());

            ///Calculator Calculator1 = new Calculator(first,second);
            ///Calculator1.Addition();
            ///Calculator1.substraction();


            ///Console.WriteLine("please enter the first number");
            ///int third = Convert.ToInt32(Console.ReadLine());
            ///Console.WriteLine("please enter the second number");
            ///int fourth = Convert.ToInt32(Console.ReadLine());

            /// Calculator Calculator2 = new Calculator(third,fourth);
            ///Calculator2.Addition();
            ///   Calculator2.substraction();

            ///Console.WriteLine("please enter the first number");
            ///int fifth = Convert.ToInt32(Console.ReadLine());
            ///Console.WriteLine("please enter the second number");
            ///int sixth = Convert.ToInt32(Console.ReadLine());

            ///Calculator Calculator3 = new Calculator(fifth, sixth);
            ///  Calculator3.Addition();
            ///Calculator3.substraction();
            ///Calculator3.Multiplication();

            ///Console.WriteLine("please enter the first number");
            ///int seventh = Convert.ToInt32(Console.ReadLine());
            ///Console.WriteLine("please enter the second number");
            ///int eighth = Convert.ToInt32(Console.ReadLine());

            ///Calculator Calculator4 = new Calculator(seventh, eighth);
            ///Calculator4.Addition();
            ///Calculator4.substraction();
            ///Calculator4.Multiplication(); 
            ///Calculator4.Division();


            Console.WriteLine("please choose a day 'from 1 to 7'");
            int day = Convert.ToInt32(Console.ReadLine());
            WeekDays.FindDayWhichFallsOnWeek(day);
            Console.ReadLine();

        }
    }
}
