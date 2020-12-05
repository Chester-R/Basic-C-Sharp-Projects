using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignmentPart2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var today = new DateTime();
                today = DateTime.Now;
                bool validAnswer = false;
                int userAge = 0;
                while (!validAnswer)
                {
                    Console.Write("User, enter your age: ");
                    validAnswer = int.TryParse(Console.ReadLine(), out userAge);
                    if (!validAnswer)
                    {
                        Console.WriteLine("Please enter digits only, no decimal.");
                    }
                    if (userAge <= 0)
                    {
                        throw new NegativeZerosException();
                    }
                }
                var birthYear = today.Year - userAge;
                Console.WriteLine($"Your birthyear is {birthYear}");

            }
            catch (NegativeZerosException)
            {
                Console.WriteLine("Invalid age format.");
            }
            catch (Exception)
            {
                Console.WriteLine("System Error, please contact your System Administrator");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
