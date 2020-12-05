using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Chester";
            var myAge = 24;

            Console.WriteLine($"My name is {myName}, I am {myAge} year old.");

            var employee = new Employee(myName, "Rimando", 1003);

            Console.WriteLine($"Employee Name: {employee.FirstName} {employee.LastName} \nEmployee ID: {employee.Id} \n Employee Department: {employee.Department}");

            Console.ReadLine();

        }
    }
}
