using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your phone number: ");
            string phoneNumber = Console.ReadLine();
            File.WriteAllText(@"C:\Users\chest\source\repos\FileIOAssignment\logs.txt", phoneNumber);
            string textPhoneNumber = File.ReadAllText(@"C:\Users\chest\source\repos\FileIOAssignment\logs.txt");
            Console.WriteLine( $"Phone Number: { textPhoneNumber}" );

            Console.ReadLine();
        }
    }
}
