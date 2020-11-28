using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.setId(31);
            employee2.setId(31);

            if (employee1 == employee2)
            {
                Console.WriteLine("Employee 1 is the same person as Employee 2.");
            }
            else if (employee1 != employee2)
            {
                Console.WriteLine("Employee 1 is the different person from Employee 2.");
            }

            Console.ReadLine();
        }
    }

    class Employee
    {
        public int Id;

        public void setId(int id)
        {
            Id = id;
        }

        public static bool operator== (Employee emp1, Employee emp2)
        {
            bool status = false;
            if (emp1.Id == emp2.Id)
            {
                status = true;
            }
            return status;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            bool status = false;
            if (emp1.Id != emp2.Id)
            {
                status = true;
            }
            return status;
        }

    }
}
