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
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static string Modulus(string num1)
        {
            double num = Convert.ToDouble(num1);
            string remainder = Convert.ToString(num % 2);
            return remainder;
        }
    }
}
