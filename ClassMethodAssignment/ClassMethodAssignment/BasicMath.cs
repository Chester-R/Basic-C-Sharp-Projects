using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public static class BasicMath
    {
        public static void OverTwo(int num)
        {
            int answer = num / 2;
            Console.WriteLine($"{num} divided by 2 is equal to {answer}");
        }

        public static void OverTwo(out int answer, int num)
        {
            answer = num / 2;
            Console.WriteLine($"{num} divided by 2 is equal to {answer}");
        }



      

    }
}
