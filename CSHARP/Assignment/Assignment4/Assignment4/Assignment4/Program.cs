using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        public static void Display(string firstName, string lastName)
        {
            Console.WriteLine(firstName.ToUpper());
            Console.WriteLine(lastName.ToUpper());
        }

        public static void Main()
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            Program.Display(firstName, lastName);

            Console.WriteLine("----------CHARACTER OCCURANCE----------");
            OccuranceCount.Test();

            Console.WriteLine("--------EXCEPTION HANDLING--------------");
            Exception_Handling.Handling();

            Console.WriteLine("=======SCHOLARSHIP MANAGEMENT=======");
            Scholarship s = new Scholarship();
            Console.WriteLine("Scholarship Amount");
            Console.WriteLine(s.stud(89,60000));
            Console.WriteLine("========DOCTOR'S DETAILS==========");
            Doctor.info();
            Console.Read();

        }

    }
}









