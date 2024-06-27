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
                Console.Write("Enter an integer :");
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new ArgumentException("Number cannot be negative.");
                }

                Console.WriteLine($"Entered number: {number}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}. Please enter a valid Number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}


