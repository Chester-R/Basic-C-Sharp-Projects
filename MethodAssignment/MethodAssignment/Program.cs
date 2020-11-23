using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mathOperation = { "Addition", "Subtraction", "Multiplication", "Division"};
            
            //Input the two numbers to be used
            Console.Write("Input 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Options of Math Operation
            for (int i = 0; i < mathOperation.Length; i++)
            {
                Console.WriteLine($"[{i}] : {mathOperation[i]}");
            }
            Console.Write("Choose Math Operation to use: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            
            //Math Operations
            if (choice == 0)
            {
                int sum = MathOperation.Add(num1, num2);
                Console.WriteLine($"{num1} + {num2} = {sum}");
            }
            else if (choice == 1)
            {
                int difference = MathOperation.Subtraction(num1, num2);
                Console.WriteLine($"{num1} - {num2} = {difference}");
            }
            else if (choice == 2)
            {
                int product = MathOperation.Multiplication(num1, num2);
                Console.WriteLine($"{num1} * {num2} = {product}");
            }
            else if (choice == 3)
            {
                int quotient = MathOperation.Division(num1, num2);
                Console.WriteLine($"{num1} / {num2} = {quotient}");
            }
            else
            {
                Console.WriteLine("Wrong input for Math Operation.");
            }

            Console.ReadLine();
        }

    }//End of Program Class

}
