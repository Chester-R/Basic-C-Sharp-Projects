using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicMath math = new BasicMath();
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //method 1
            //math.Divide(num);
            //end of method 1

            //method 2
            int quotient = 0;
            BasicMath.Divide(out quotient, num);
            //end of method 2

            //for method 2
            Console.WriteLine($"{num} divide by 2 is equal to {quotient}");

            Console.ReadLine();
        }

        
    }
}
