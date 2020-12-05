using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssignment
{
    class Employee
    {
        public Employee(string fName, string lName, int empId) : this(fName, lName, empId, "IT Department")
        { 
        
        }
        public Employee(string fName, string lName, int empId, string empDepartment)
        {
            FirstName = fName;
            LastName = lName;
            Id = empId;
            Department = empDepartment;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public string Department { get; set; }
    }
}
