using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Concatenate string
            //string Greeting = "Good day, ";
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //string message = ", hope you enjoy studying C#.";

            //Console.WriteLine(Greeting + name + message);
            //Console.ReadLine();

            //2. String converted to upper case
            //string Greeting = "Good day, ";
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //name = name.ToUpper();
            //string message = ", hope you enjoy studying C#.";

            //Console.WriteLine(Greeting + name + message);
            //Console.ReadLine();

            //3. String builder
            StringBuilder sb1 = new StringBuilder("Quote:\n");
            sb1.Append("\"I rather trust and regret,\n");
            sb1.Append("than doubt and regret.\"\n");
            sb1.Append("\t\t-Kirigaya Kazuto");
            Console.WriteLine(sb1);
            Console.ReadLine();

        }
    }
}
