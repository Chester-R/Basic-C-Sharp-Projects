using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApprovalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insurance Approval");
            Console.Write("What is your age? ");
            string yourage= Console.ReadLine();
            int age = Convert.ToInt32(yourage);

            Console.Write("Have you ever had a DUI? [true/false] ");
            string ans = Console.ReadLine();
            bool ansDUI = Convert.ToBoolean(ans);

            Console.Write("How many speeding tickets do you have? ");
            string speedticket = Console.ReadLine();
            int ticket = Convert.ToInt32(speedticket);

            bool qualified = age > 15 && ansDUI == false && ticket <= 3;

            Console.WriteLine("Qualified? " + qualified);
            Console.ReadLine();


        }
    }
}
