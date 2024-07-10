using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC4
{
    public class EmployeeDetails
    {
       public static void details()
        {
               //Creation of Generic list
                List<Employee> empList = new List<Employee>();

                empList.Add(new Employee(1001, "Malcolm", "Daruwalla", "Manager", "16-11-1984", "08-06-2011", "Mumbai"));
                empList.Add(new Employee(1002, "Asdin", "Dhalla", "AsstManager", "20/08/1984", "07-07-2012", "Mumbai"));
                empList.Add(new Employee(1003, "Madhavi", "Oza", "Consultant", "14/11/1987", "12-04-2015", "Pune"));
                empList.Add(new Employee(1004, "Saba", "Shaikh", "SE", "03-06-1990", "02-02-2016", "Pune"));
                empList.Add(new Employee(1005, "Nazia", "Shaikh", "SE", "08-03-1991", "02-02-2016", "Mumbai"));
                empList.Add(new Employee(1006, "Amit", "Pathak", "Consultant", "7/11/1989", "08-08-2014", "Chennai"));
                empList.Add(new Employee(1007, "Vijay", "Natrajan", "Consultant", "2/12/1989", "01-06-2015", "Mumbai"));
                empList.Add(new Employee(1008, "Rahul", "Dubey", "Associate", "11-11-1993", "06-11-2014", "Chennai"));
                empList.Add(new Employee(1009, "Suresh", "Mistry", "Associate", "12/8/1992", "03-12-2014", "Chennai"));
                empList.Add(new Employee(1010, "Sumit", "Shah", "Manager", "12-04-1991", "02-01-2016", "Pune"));

               
                Console.WriteLine("Choose an option:");
                Console.WriteLine("a. Display detail of all the employees");
                Console.WriteLine("b. Display details of all employees whose location is not Mumbai");
                Console.WriteLine("c. Display details of all employees whose title is AsstManager");
                Console.WriteLine("d. Display details of all employees whose Last Name starts with S");
            Console.WriteLine("=============================================");

                char option = char.ToLower(Console.ReadKey().KeyChar); 

            switch (option)
            {
                case 'a': // Display all employees
                    Console.WriteLine(" Display detail of all the employees:");
                    Console.WriteLine("=======================================");
                    foreach (var emp in empList)
                    {
                        Console.WriteLine(emp.ToString());
                    }
                    break;

                case 'b': // Display employees not in Mumbai
                    Console.WriteLine(" Display details of all employees whose location is not Mumbai:");
                    Console.WriteLine("==========================================");
                    foreach (var emp in empList)
                    {
                        if (emp.City != "Mumbai")
                        {
                            Console.WriteLine(emp.ToString());
                        }
                    }
                    break;

                case 'c': // Display employees with title AsstManager
                    Console.WriteLine(" Display details of all employees whose title is AsstManager:");
                    Console.WriteLine("==========================================");
                    foreach (var emp in empList)
                    {
                        if (emp.Title == "AsstManager")
                        {
                            Console.WriteLine(emp.ToString());
                        }
                    }
                    break;

                case 'd': // Display employees whose Last Name starts with S
                    Console.WriteLine(" Display details of all employees whose Last Name starts with S:");
                    Console.WriteLine("=====================================");
                    foreach (var emp in empList)
                    {
                        if (emp.LastName.StartsWith("S"))
                        {
                            Console.WriteLine(emp.ToString());
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose a valid option (a, b, c, d).");
                    break;
                }
            }

        }
        public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string DOB { get; set; }
        public string DOJ { get; set; }
        public string City { get; set; }

        //constructor
        public Employee(int id, string firstName, string lastName, string title, string dob, string doj, string city)
        {
            EmployeeID = id;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            DOB = dob;
            DOJ = doj;
            City = city;
        }

        // Override
        public override string ToString()
        {
            return $"EmployeeID: {EmployeeID}, Name: {FirstName} {LastName}, Title: {Title}, DOB: {DOB}, DOJ: {DOJ}, City: {City}";
        }
    }
}

