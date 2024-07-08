
using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Console.WriteLine("============SQUARE OF NUMBER===========");
        Program.SquareOfNumbers();
        Console.WriteLine("=========FILTER WORDS==========");
        Program.letters();
        Console.WriteLine("========EMPLOYEE DETAILS===============");
        Program.EmployeeOperations();
        Console.Read();
    }
        
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public decimal EmpSalary { get; set; }
    }



    static void SquareOfNumbers()
    {
        int[] numbers = { 3, 21,30 };

        foreach (int number in numbers)
        {
            int square = number * number;

            if (square > 20)
            {
                Console.WriteLine($"{number} - {square}");
            }
        }
    }

 
    static void letters()
    {
        List<string> words = new List<string>
        {
            "hello",
            "drum",
            "mum",
            "key",
            "alarm",
            "band",
            "amsterdam"
        };

        foreach (string word in words)
        {
            if (word.StartsWith("a", StringComparison.OrdinalIgnoreCase) && word.EndsWith("m", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(word);
            }
        }
    }

  
    static void EmployeeOperations()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "Kajal", EmpCity = "Bangalore", EmpSalary = 50000 },
            new Employee { EmpId = 2, EmpName = "Anchal", EmpCity = "Mumbai", EmpSalary = 60000 },
            new Employee { EmpId = 3, EmpName = "Palak", EmpCity = "Bangalore", EmpSalary = 55000 },
            new Employee { EmpId = 4, EmpName = "Payal", EmpCity = "Delhi", EmpSalary = 48000 },
            new Employee { EmpId = 5, EmpName = "Meenakshi", EmpCity = "Chennai", EmpSalary = 45000 }
        };

        Console.WriteLine("Choose an employee operation:");
        Console.WriteLine("1. Display all employees");
        Console.WriteLine("2. Display employees with salary greater than 45000");
        Console.WriteLine("3. Display employees from Bangalore");
        Console.WriteLine("4. Display employees sorted by name");

        int operation;
        bool isValidOperation = int.TryParse(Console.ReadLine(), out operation);

        if (isValidOperation)
        {
            switch (operation)
            {
                case 1:
                    Console.WriteLine("All Employees:");
                    DisplayAllEmployees(employees);
                    break;
                case 2:
                    Console.WriteLine("Employees with Salary > 45000:");
                    DisplayEmployeesAboveSalary(employees, 45000);
                    break;
                case 3:
                    Console.WriteLine("Employees from Bangalore:");
                    DisplayEmployeesFromCity(employees, "Bangalore");
                    break;
                case 4:
                    Console.WriteLine("Employees sorted by Name (Ascending):");
                    DisplayEmployeesByNameAscending(employees);
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please enter a number between 1 and 4.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

   
    static void DisplayAllEmployees(List<Employee> employees)
    {
        foreach (var emp in employees)
        {
            Console.WriteLine($"EmpId: {emp.EmpId}, EmpName: {emp.EmpName}, EmpCity: {emp.EmpCity}, EmpSalary: {emp.EmpSalary}");
        }
    }

    static void DisplayEmployeesAboveSalary(List<Employee> employees, decimal salaryThreshold)
    {
        foreach (var emp in employees)
        {
            if (emp.EmpSalary > salaryThreshold)
            {
                Console.WriteLine($"EmpId: {emp.EmpId}, EmpName: {emp.EmpName}, EmpCity: {emp.EmpCity}, EmpSalary: {emp.EmpSalary}");
            }
        }
    }

    static void DisplayEmployeesFromCity(List<Employee> employees, string city)
    {
        foreach (var emp in employees)
        {
            if (emp.EmpCity.Equals(city, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"EmpId: {emp.EmpId}, EmpName: {emp.EmpName}, EmpCity: {emp.EmpCity}, EmpSalary: {emp.EmpSalary}");
            }
        }
    }

    static void DisplayEmployeesByNameAscending(List<Employee> employees)
    {
        employees.Sort((emp1, emp2) => string.Compare(emp1.EmpName, emp2.EmpName));

        foreach (var emp in employees)
        {
            Console.WriteLine($"EmpId: {emp.EmpId}, EmpName: {emp.EmpName}, EmpCity: {emp.EmpCity}, EmpSalary: {emp.EmpSalary}");
        }
    }
}
