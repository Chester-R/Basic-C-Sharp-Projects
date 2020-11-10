using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            //Person 1
            Console.WriteLine("Person 1");
            Console.Write("Enter hourly rate: ");
            string hourrate1 = Console.ReadLine();
            double hrate1 = Convert.ToDouble(hourrate1);
            Console.Write("Enter hours work per week: ");
            string hoursperweek1 = Console.ReadLine();
            double hweek1 = Convert.ToDouble(hoursperweek1);

            //Person 2
            Console.WriteLine("Person 2");
            Console.Write("Enter hourly rate: ");
            string hourrate2 = Console.ReadLine();
            double hrate2 = Convert.ToDouble(hourrate2);
            Console.Write("Enter hours work per week: ");
            string hoursperweek2 = Console.ReadLine();
            double hweek2 = Convert.ToDouble(hoursperweek2);

            //Annual salary
            double weekSalary1 = hrate1 * hweek1;
            double aSalary1 = weekSalary1 * 52.143;
            Console.WriteLine("Annual salary of Person 1: " + aSalary1);
            double weekSalary2 = hrate2 * hweek2;
            double aSalary2 = weekSalary2 * 52.143;
            Console.WriteLine("Annual salary of Person 2: " + aSalary2);

            //Comparison of Annual Salary
            bool comp = aSalary1 > aSalary2;
            Console.WriteLine("Person 1 makes more money than Person 2 is " + comp);

            Console.ReadLine();



        }
    }
}
