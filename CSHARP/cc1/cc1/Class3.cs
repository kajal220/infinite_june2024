using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc1
{
    class Class3
    {
        static void Remove()
        {
            Console.WriteLine("enter the integers");
            String input = Console.ReadLine();
            string[] num = input.Split(' ');
            if (num.Length != 3)
            {
                Console.WriteLine("enter the integers with spaces");
                return;
            }
            int a = int.Parse(num[0]);
            int b = int.Parse(num[1]);
            int c = int.Parse(num[2]);
            int largest = Math.Max(a, Math.Max(b, c));
            Console.WriteLine(largest);
            Console.Read();
        }

    }
}
