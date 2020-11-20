using System;
using System.Collections.Generic;

namespace ConsoleAppIterationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Part 1
            //string[] greetingsArray = { "Good Morning", "Bonjour", "Ohaiyo Gozaimasu", "Buenas dias", "Boungiorno" };
            //Console.Write("What is your name: ");
            //string name = Console.ReadLine();

            //for (int i = 0; i < greetingsArray.Length; i++)
            //{
            //    Console.WriteLine($"{greetingsArray[i]} {name}!");
            //}
            //Console.ReadLine();

            ////Part 2 Infinite loop
            //int months = 12;

            //for (int j = 0; j != months; j += 5)
            //{
            //    Console.WriteLine($"Months Counted: {j}");
            //    Console.WriteLine($"Months Left: {months - j}");
            //}
            //Console.ReadLine();

            ////Part 2 fix infinite loop
            //int months = 12;

            //for (int j = 0; j != months; j ++)
            //{
            //    Console.WriteLine($"Months Counted: {j}");
            //    Console.WriteLine($"Months Left: {months - j}");
            //}
            //Console.ReadLine();

            //Part 3 using < operator
            //int months = 12;

            //for (int j = 0; j < months; j++)
            //{
            //    Console.WriteLine($"Months Counted: {j}");
            //    Console.WriteLine($"Months Left: {months - j}");
            //}
            //Console.ReadLine();

            ////Part 3 using <= operator
            //int months = 12;

            //for (int j = 1; j <= months; j++)
            //{
            //    Console.WriteLine($"Months Counted: {j}");
            //    Console.WriteLine($"Months Left: {months - j}");
            //}
            //Console.ReadLine();

            ////Part 4
            //List<string> studentNames = new List<string>() { "Mike", "Angelo", "Rob", "Samuel", "Amir" };
            //Console.Write("Name of Student: ");
            //string student = Console.ReadLine();

            //if (!studentNames.Contains(student))
            //{
            //    Console.WriteLine($"{student} is not in the list.");
            //}
            //else
            //{
            //    foreach (string nameIndex in studentNames)
            //    {
            //        if (nameIndex == student)
            //        {
            //            Console.WriteLine($"Student Profile for {student}");
            //        }
            //    }
            //}
            //Console.ReadLine();

            ////Part 5
            //List<string> availableFruits = new List<string>() { "Apple", "Orange", "Peach", "Banana", "Grapes", "Pineapple", "Banana" };
            //Console.Write("What fruit do you need: ");
            //string likeFruits = Console.ReadLine();
            //if (!availableFruits.Contains(likeFruits))
            //{
            //    Console.WriteLine($"{likeFruits} is not available.");
            //}
            //else
            //{
            //    foreach (string fruit in availableFruits)
            //    {
            //        if (fruit == likeFruits)
            //        {
            //            Console.WriteLine($"{fruit} is now available.");
            //        }
            //    }
            //}

            //Console.ReadLine();

            //Part 6
            List<string> listofFruits = new List<string>() { "Apple", "Orange", "Peach", "Banana", "Grapes", "Pineapple", "Banana", "Apple", "Banana" };
            HashSet<string> hashsetFruit = new HashSet<string>();
            
            foreach (string fruit in listofFruits)
            {
                if ( !hashsetFruit.Add(fruit) )
                {
                    Console.WriteLine($"{fruit} is already in the list.");
                }
                else
                {
                    Console.WriteLine($"{fruit} is available.");
                }
            }

            Console.ReadLine();


        }
    }
}
