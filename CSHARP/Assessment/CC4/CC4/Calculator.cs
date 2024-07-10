using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC4
{ 

   public class Calculator
    {
        // using delegate to calculate
        delegate int CalculatorOperation(int x, int y);

       public static void calculator_funtionalities()
        {
            // using Dictionary with lambdas function
            Dictionary<string, CalculatorOperation> operations = new Dictionary<string, CalculatorOperation>
        {
            { "Addition", (x, y) => x + y },
            { "Subtraction", (x, y) => x - y },
            { "Multiplication", (x, y) => x * y }
        };

           
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

           
            foreach (var operation in operations)
            {
                int result = operation.Value(num1, num2);
                Console.WriteLine($"{operation.Key} Result: {num1} {GetOperationSymbol(operation.Key)} {num2} = {result}");
            }
 
        }

        static string GetOperationSymbol(string operation)
        {
            switch (operation)
            {
                case "Addition":
                    return "+";
                case "Subtraction":
                    return "-";
                case "Multiplication":
                    return "*";
                default:
                    return "";
            }
        }
    }

}

