using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC2
{
    class Exception_Handing
    {
        public static void exception()
        {
            try
            {
                Console.WriteLine("Enter a positive integer:");
                int n1 = int.Parse(Console.ReadLine());

            }

            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }

        }

        static int ReadPositiveInteger()
        {

            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                throw new ArgumentException("number cannot be negative.");
            }

            return number;
        }



    }

}
   
