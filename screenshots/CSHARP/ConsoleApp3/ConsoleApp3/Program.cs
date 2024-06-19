using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first value");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second value");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("number is equal");
            }
            else
            {
                Console.WriteLine("number is not equal");
            }
            Console.Read();

        }
    }
}
