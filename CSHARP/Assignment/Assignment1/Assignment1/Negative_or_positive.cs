using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Negative_or_positive
    {
        public static void Check()
        {

            Console.Write("Enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)

            {

                Console.WriteLine("The number is positive.");

            }

            else if (number < 0)

            {

                Console.WriteLine("The number is negative.");

            }

            else

            {

                Console.WriteLine("The number is zero.");

            }
        }
    }
}
