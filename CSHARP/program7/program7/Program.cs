using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number:");
            int n = int.Parse(Console.ReadLine());
            {
                Console.WriteLine("{0} {0} {0} {0}", n);
                Console.WriteLine("{0}{0}{0}{0}", n);
                Console.WriteLine("{0} {0} {0} {0}", n);
                Console.WriteLine("{0}{0}{0}{0}", n);
            }
            Console.Read();
        }
    }
}
