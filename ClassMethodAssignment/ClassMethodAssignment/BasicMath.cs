using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class BasicMath
    {
        public void Divide(int num)
        {
            int quotient = num / 2;
            Console.WriteLine($"{num} divide by 2 is equal to {quotient}");
        }

        public static void Divide(out int quotient, int num)
        {
            quotient = num / 2;
        }

      

    }
}
