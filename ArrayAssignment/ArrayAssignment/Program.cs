using System;
using System.Collections.Generic;


namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ////#1
            //string[] greetingsArray = new string[] { "Good Morning", "Ohaiyo Gozaimasu", "Bonjour", "Buenas dias", "Buongiorno" };
            //int greetLow = greetingsArray.GetLowerBound(0);
            //int greetUp = greetingsArray.GetUpperBound(0);

            //Console.WriteLine("Choose your greetings: ");
            ////iterate the array
            //for (int i = greetLow; i <= greetUp; i++)
                //Console.WriteLine($"   [{i}]: {greetingsArray[i]}"); //interpolate string
            //int greetings = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(greetingsArray[greetings]);
            //Console.Read();

            ////#2
            //int[] packsArray = new int[] { 10, 50, 100, 500 };
            //int packLow = packsArray.GetLowerBound(0);
            //int packUp = packsArray.GetUpperBound(0);

            //Console.WriteLine("How many pack do you need: ");
            ////iterate the array
            //for (int j = packLow; j <= packUp; j++)
                //Console.WriteLine($"   [{j}]: {packsArray[j]} packs");
            //int packs = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"{packsArray[packs]} packs");
            //Console.Read();

            ////#3
            //int[] packsArray = new int[] { 10, 50, 100, 500 };
            //int packLow = packsArray.GetLowerBound(0);
            //int packUp = packsArray.GetUpperBound(0);

            //Console.WriteLine("How many pack do you need: ");
            ////iterate the array
            //for (int j = packLow; j <= packUp; j++)
                //Console.WriteLine($"   [{j}]: {packsArray[j]} packs");
            //int packs = Convert.ToInt32(Console.ReadLine());

            //if (packs > packUp)
            //{
            //    Console.WriteLine("Invalid input");
            //}
            //else
            //{
            //    Console.WriteLine($"{packsArray[packs]} packs");
            //}

            //Console.Read();

            //#4
            List<string> greetingsList = new List<string>();
            greetingsList.Add("Good Morning");
            greetingsList.Add("Ohaiyo Gozaimasu");
            greetingsList.Add("Bonjour");
            greetingsList.Add("Buenas dias");
            greetingsList.Add("Buongiorno");

            Console.WriteLine("Choose your greeting: ");
            for (int i = 0; i < greetingsList.Count; i++)
                Console.WriteLine($"[{  i}] : {greetingsList[i]}");
            int greet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(greetingsList[greet]);
            Console.Read();

        }
    }
}
