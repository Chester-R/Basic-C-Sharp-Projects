using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input seconds number (not required): ");
            string num = Console.ReadLine();

            if ( string.IsNullOrEmpty(num))
            {
                int quotient = BasicMath.MathOp(num1);
                Console.WriteLine($"Answer is equal to {quotient}");
               
            }
            else
            {
                int num2 = Convert.ToInt32(num);
                int quotient = BasicMath.MathOp(num1, num2);
                Console.WriteLine($"Answer is equal to {quotient}");

            }

            Console.ReadLine();
        }
    }
}
