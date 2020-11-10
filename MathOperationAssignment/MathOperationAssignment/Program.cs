using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number 1
            Console.Write("Input a number: ");
            string number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);
            int value1 = num1 * 50;
            Console.WriteLine(num1 + " multiply to 50 = " + value1);
            Console.ReadLine();

            //Number 2
            Console.Write("Input a number: ");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);
            int value2 = num2 + 25;
            Console.WriteLine(num2 + " add to 25 = " + value2);
            Console.ReadLine();

            //Number 3
            Console.Write("Input a number: ");
            string number3 = Console.ReadLine();
            double num3 = Convert.ToDouble(number3);
            double value3 = num3 / 12.5;
            Console.WriteLine(num3 + " divide by 12.5 = " + value3);
            Console.ReadLine();

            //Number 4
            Console.Write("Input a number: ");
            string number4 = Console.ReadLine();
            double num4 = Convert.ToDouble(number4);
            bool greater = num4 > 50;
            Console.WriteLine(num4 + " > 50 is " + greater);
            Console.ReadLine();

            //Number 5
            Console.Write("Input a number: ");
            string number5 = Console.ReadLine();
            int num5 = Convert.ToInt32(number5);
            int remainder = num5 % 7;
            Console.WriteLine("Remainder of " + num5 + " divides by 7 is " + remainder);
            Console.ReadLine();

        }
    }
}
