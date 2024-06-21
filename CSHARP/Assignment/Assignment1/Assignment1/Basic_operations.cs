using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Basic_operations
    
        {
            public static void functions()
            {
                Console.Write("Enter the first number: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int n2 = int.Parse(Console.ReadLine());

                int addition = n1 + n2;
                int subtraction = n1 - n2;
                int multiplication = n1 * n2;
                int division = n1 / n2;
                Console.WriteLine(addition);
                Console.WriteLine(subtraction);
                Console.WriteLine(multiplication);
                Console.WriteLine(division);

            }
        }
    }

