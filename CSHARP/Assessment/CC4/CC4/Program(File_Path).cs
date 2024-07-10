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

            // Directory path 
           
            {
                string directoryPath = @"C:\Batch_june2024\CSHARP\Assessment\CC4";
                string fileName = "TestFile.txt";
                string filePath = Path.Combine(directoryPath, fileName);

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Request text input from the user
                Console.WriteLine("Please enter the text to append to the file:");
                string userText = Console.ReadLine();

                
                string timeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string textToAppend = $"[{timeStamp}] {userText}";

                StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(filePath, append: true);
                writer.WriteLine(textToAppend);
                Console.WriteLine($"Text appended successfully to {filePath} with a timestamp.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
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
    
