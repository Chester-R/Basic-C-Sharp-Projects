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
            Console.Write("Enter a whole number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int answer = 0;
            BasicMath.OverTwo(out answer,num);
            

            Console.ReadLine();
        }

        
    }
}
