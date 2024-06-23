using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3

{

    public class Customer

    {
        public int CustomerId;
        public string Name;
        public int Age;
        public string Phone;
        public string City;
        public Customer()
        {

        }
        public Customer(int customerId, string name, int age, string phone, string city)
        {
            CustomerId = customerId;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;
        }


        public static void DisplayCustomer()
        {
            Console.WriteLine("Enter Customer ID:");
            int customerId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Phone:");
            string phone = Console.ReadLine();

            Console.WriteLine("Enter City:");
            string city = Console.ReadLine();

            Console.WriteLine("\nCustomer Details:");
            Console.WriteLine($"Customer ID: {customerId}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"City: {city}");

        }

        ~Customer()
        {

            Console.WriteLine($"Customer {Name} with ID {CustomerId} is being destroyed.");
        }
    }
}


