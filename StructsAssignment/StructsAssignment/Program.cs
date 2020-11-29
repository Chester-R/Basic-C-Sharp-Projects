using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAssignment
{
    class Program
    {
        public struct Number
        {
            public decimal Amount;
        }
        static void Main(string[] args)
        {
            Number amount1 = new Number();
            amount1.Amount = 100.75m;

            Console.WriteLine($"${amount1.Amount}");

            Console.ReadLine();
        }
    }
}
