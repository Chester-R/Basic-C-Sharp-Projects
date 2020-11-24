using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethod1
{
    class Program
    {
        static void Main(string[] args)
        {
            //# 1 & 2
            //Console.Write("Input first number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int total = BasicMath.Add(num1, num2);
            //Console.WriteLine($"{num1} + {num2} = {total}");

            //Console.ReadLine();

            //# 3 & 4
            //Console.Write("Input first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Input second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //double product = BasicMath.Multiply(num1, num2);
            //Console.WriteLine($"{num1} * {num2} = {product}");

            //Console.ReadLine();

            //# 5 & 6
            Console.WriteLine("\t\tODD or EVEN");
            Console.Write("Input any whole number: ");
            string num1 = Console.ReadLine();
            int remainder = Convert.ToInt32(BasicMath.Modulus(num1));
            if (remainder > 0)
            {
                Console.WriteLine($"{num1} is an Odd number.");
            }
            else
            {
                Console.WriteLine($"{num1} is an Even number.");
            }
            Console.ReadLine();
        }
    }
}
