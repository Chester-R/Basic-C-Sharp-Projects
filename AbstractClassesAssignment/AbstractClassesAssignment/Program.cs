﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee name = new Employee();
            name.firstName = "Sample";
            name.lastName = "Student";
            name.SayName();

            Console.ReadLine();
        }
    }
}
