using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethod1
{
    class BasicMath
    {
        //#1 & 2
        public static int Operation(int num1, int num2)
        {
            int total = num1 + num2;
            return total;
        }
        //#3 & 4
        public static int Operation(double num1, double num2)
        {
            int product = Convert.ToInt32(num1 * num2);
            return product;
        }
        //#5 & 6
        public static int Operation(string num1)
        {
            int num = Convert.ToInt32(num1);
            int remainder = num % 2;
            return remainder;
        }
    }
}
