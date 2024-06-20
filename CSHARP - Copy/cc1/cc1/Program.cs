using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc1
{
    class Program

    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            Console.WriteLine("Enter the index to remove :");
            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= str.Length)
            {
                Console.WriteLine("invalid index");
            }
            else
            {
                string result = str.Remove(index, 1);
                Console.WriteLine(result);
                Console.Read();
            }
        }
    }
}

