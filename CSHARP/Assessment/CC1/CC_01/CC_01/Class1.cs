using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc1
{
    class Class1
    {
       static void Main(String[] args)
        {
            Console.WriteLine(test(("abcd")));
            Console.WriteLine(test("a"));
            Console.WriteLine(test("axy"));
            Console.ReadLine();

        }
        public static string test(string str)
        {
            return str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1)
                : str;
        }
              }

    }

