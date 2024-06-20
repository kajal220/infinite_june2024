using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number:");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("number is positive");
            }
            else
            {
                Console.WriteLine("number is negative");
            }
            Console.Read();
        }
    }
}
