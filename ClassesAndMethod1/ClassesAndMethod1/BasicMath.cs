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
            return num1 + num2;
        }
        //#3 & 4
        public static double Operation(double num1, double num2)
        {
            return num1 * num2;
        }
        //#5 & 6
        public static string Operation(string num1)
        {
            int num = Convert.ToInt32(num1);
            string remainder = Convert.ToString(num % 2);
            return remainder;
        }
    }
}
