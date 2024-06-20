using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lname = Console.ReadLine();
            Console.WriteLine("enter you age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("your first name is:{0}, last name is:{1}, and age is: {2}", fname, lname, age);
            Console.Read();
        }
    }
}
