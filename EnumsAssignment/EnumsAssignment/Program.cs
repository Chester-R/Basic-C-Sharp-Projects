using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
    public enum DayCodes
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6
    };
    class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("Enter the current day of the week: ");
            string today = Console.ReadLine();
            //DayCodes getParse;
            //bool checkParse = Enum.TryParse(today, out getParse);
            //Console.WriteLine(getParse);
            try
            {
                DayCodes dayValue = (DayCodes)Enum.Parse(typeof(DayCodes), today, true);
                if (Enum.IsDefined(typeof(DayCodes), dayValue))
                {
                    Console.WriteLine($"Today is {dayValue} {(int)dayValue}");
                }
                else
                {
                    Console.WriteLine($"{today} is not an underlying value of Days.");
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
           
            Console.ReadLine();

            
        }



    }
}
