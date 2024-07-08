using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class_Library;


namespace LibraryClient
{
        class Program
        {
            static void Main(string[] args)
            {
              
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Enter your age: ");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    
                    string concessionMessage = TravelConcession.CalculateConcession(age);

                    
                    Console.WriteLine();
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Age: {age}");
                    Console.WriteLine($"Concession: {concessionMessage}");
                }
                else
                {
                    Console.WriteLine("Invalid age input. Please enter a valid integer.");
                }

                Console.ReadLine();
            }
        }
    }


    
