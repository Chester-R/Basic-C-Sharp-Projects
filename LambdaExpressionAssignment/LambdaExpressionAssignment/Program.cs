using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    public class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Id { get; set; }
        public Employee(string fName, string lName, int iD) 
        {
            Fname = fName;
            Lname = lName;
            Id = iD;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Joe", "Gibson", 1001));
            employees.Add(new Employee("Joe", "Marshall", 1004));
            employees.Add(new Employee("Marcos", "Morris", 1027));
            employees.Add(new Employee("Micheal", "Jordan", 1024));
            employees.Add(new Employee("Lebron", "James", 1014));
            employees.Add(new Employee("Luka", "Doncic", 1077));
            employees.Add(new Employee("Stephen", "Curry", 1030));
            employees.Add(new Employee("Larry", "Bird", 1033));
            employees.Add(new Employee("Duncan", "Robinson", 1055));
            employees.Add(new Employee("Klay", "Thompson", 1011));

            //Using lambda expression
            //List<Employee> newEmployee = employees.Where(x => x.Fname == "Joe").ToList();
            //foreach (Employee employee in newEmployee)
            //{
            //    Console.WriteLine($"ID: {employee.Id} Name: {employee.Fname} {employee.Lname} ");
            //}

            //Using foreach Loop
            //foreach (Employee employee in employees)
            //{
            //    List<Employee> employees1 = new List<Employee>();
            //    if (employee.Fname == "Joe")
            //    {
            //        employees1.Add(employee);
            //        Console.WriteLine($"ID: {employee.Id} Name: {employee.Fname} {employee.Lname} ");
            //    }

            //}

            //List with ID greater that 1030
            List<Employee> newId = employees.Where(x => x.Id > 1030).ToList();
            foreach (Employee employee in newId)
            {
                Console.WriteLine($"ID: {employee.Id} Name: {employee.Fname} {employee.Lname} ");
            }
                Console.ReadLine();


        }
    }
}
