using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileAndDoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1. while loop

            //Random diceNum = new Random();

            //int attempt = 0;

            //while (attempt != 6 )
            //{
            //    attempt = diceNum.Next(1, 7);

            //    switch (attempt)
            //    {
            //        case 6:
            //            Console.WriteLine("You rolled 6. You win.");
            //            break;
            //        default:
            //            Console.WriteLine("You rolled " + attempt + ". Try again.");
            //            break;
            //    }
            //}
           
            //Console.ReadLine();

            //#2. do while loop
            Random diceNum = new Random();

            int attempt = 0;

            do
            {
                attempt = diceNum.Next(1, 7);

                switch (attempt)
                {
                    case 5:
                        Console.WriteLine("You rolled 5. You win.");
                        break;
                    case 6:
                        Console.WriteLine("You rolled 6. You win.");
                        break;
                    default:
                        Console.WriteLine("You rolled " + attempt + ". Try again.");
                        break;
                }
            }

            while (attempt < 5);
            
            Console.ReadLine();


        }
    }
}
