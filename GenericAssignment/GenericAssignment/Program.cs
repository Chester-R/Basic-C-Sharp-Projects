using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> Name = new Employee<string>();
            Name.Things = new List<string>() { "Micheal", "Thomas", "Venti", "Keaya", "Diluc"};

            Employee<int> Id = new Employee<int>() ;
            Id.Things = new List<int>();
            int id = 1000;

            foreach (string name in Name.Things)
            {
                id++;
                Id.Things.Add(id);
                Console.WriteLine($"ID: {id} Name: {name}");
                 
            }
            Console.ReadLine();
        }
    }
}
