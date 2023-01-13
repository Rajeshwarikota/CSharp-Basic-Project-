using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basic
{
    /// <summary>
    /// Caluculator class created to perform arithmetic oprtaions
    /// </summary>
    class Calculator
    {
        //instance variable
        public int first, second, result;

        public Calculator(int firstNumb, int secondNumb)
        {
            first = firstNumb;
            second = secondNumb;
        }
        /// <summary>
        /// Addition of 2 numbers to get sum
        /// </summary>
        public void Addition()
        {
            result = first + second;
            Console.WriteLine("sum:" + result);
        }
        public void substraction()
        {
            result = Math.Abs(first - second);
            Console.WriteLine("substraction:" + result);
          }
    }
}
