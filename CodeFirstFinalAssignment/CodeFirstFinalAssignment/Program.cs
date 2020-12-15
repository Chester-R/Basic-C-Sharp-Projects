using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student();
                student.FirstName = "Chester";
                student.LastName = "Rimando";

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
        }
    }
}
