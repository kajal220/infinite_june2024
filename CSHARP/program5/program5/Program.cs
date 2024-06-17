using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            int addition = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            int div = num1 / num2;
            Console.WriteLine("addition of two numbers is:{0}", addition);
            Console.WriteLine("subtraction of two numbers is:{0}", sub);
            Console.WriteLine("multiplication of two numbers is:{0}", mul);
            Console.WriteLine("division of two numbers is:{0}", div);
            Console.Read();

        }
    }
}
