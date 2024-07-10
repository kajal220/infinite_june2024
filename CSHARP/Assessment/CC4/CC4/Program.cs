using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CC4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Directory path 
            string directoryPath = @"C:\Batch_june2024\CSHARP\Assessment\CC4";


            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // File path
            string filePath = Path.Combine(directoryPath, "TestFile.txt");

            // Text to append
            string textToAppend = "This is my text file for Core Challenge 4.\n";

            try
            {
                // appending text to the file
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.Write(textToAppend);
                }

                Console.WriteLine("This is my text file for Core Challenge 4.");
                Console.WriteLine("File Path: " + filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine(" ");
            Console.WriteLine("===========Delegate Function=================");
            Calculator.calculator_funtionalities();
            Console.WriteLine(" ");

            Console.WriteLine("==============Displaying Employees details using generic list");
            EmployeeDetails.details();
            Console.Read();
            }
        }
    }
    
