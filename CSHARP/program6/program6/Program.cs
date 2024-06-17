using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the two numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("numbers before swapping are:{0} {1}", num1, num2);
            int temp = 0;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("numbers after swapping:");
            Console.WriteLine(num1+" "+ num2);
            Console.Read();


        }
    }
}
