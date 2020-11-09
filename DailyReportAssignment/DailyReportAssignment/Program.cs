using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College\nStudent Daily Report");
            //Question 1
            Console.WriteLine("What course are you in?");
            string courseName = Console.ReadLine();
            //Question 2
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            //Question 3
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            string help = Console.ReadLine();
            //Question 4
            Console.WriteLine("Where there any positive experiences you’d like to share? Please give specifics.");
            string posExperience = Console.ReadLine();
            //Question 5
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            //Question 6
            Console.WriteLine("How many hours did you study today?");
            string hoursStudy = Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
