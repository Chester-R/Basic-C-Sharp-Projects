using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable resign = new Employee();
            resign.Quit();

            Console.ReadLine();
        }
    }
}
