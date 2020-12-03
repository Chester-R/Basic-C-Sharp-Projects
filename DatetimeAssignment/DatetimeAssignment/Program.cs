using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = new DateTime();
            today = DateTime.Now;
            Console.WriteLine($"Current Date and Time : {today}");
            Console.Write("Input how many hours you sleep: ");
            int sleepHour = Convert.ToInt32(Console.ReadLine());
            DateTime nextTime = DateTime.Now.AddHours(sleepHour);

            Console.WriteLine($"Time that the clock will alarm: {nextTime}");

            Console.ReadLine();


        }
    }
}
