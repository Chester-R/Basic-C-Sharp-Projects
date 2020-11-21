using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<int> numList = new List<int>() { 21, 100, 50, 72 };
            for (int i = 0; i < numList.Count; i++)
            {
                try
                {
                    Console.WriteLine($"[{i}] : {numList[i]}");
                    Console.Write("Insert number to divide the given number: ");
                    int numUser = Convert.ToInt32(Console.ReadLine());
                    int quotient = numList[i] / numUser;
                    Console.WriteLine($"{numList[i]} divided by {numUser} is equal to {quotient}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Please don't divide it by zero.");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please use whole number.");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadLine();
                }
            }
        }
    }
}
