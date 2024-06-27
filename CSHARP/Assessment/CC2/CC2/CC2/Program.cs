using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC2
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter undergraduate student's name:");
            string undergradName = Console.ReadLine();

            Console.WriteLine("Enter undergraduate student's ID:");
            int undergradId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter undergraduate student's grade:");

            double grade = double.Parse(Console.ReadLine());

            Student undergrad = new Undergraduate(undergradName, undergradId, grade);

            Console.WriteLine("\nEnter graduate student's name:");
            string gradName = Console.ReadLine();

            Console.WriteLine("Enter graduate student's ID:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter graduate student's grade:");
            double gradGrade = double.Parse(Console.ReadLine());
            Student grad = new Graduate(gradName, id, gradGrade);


            Console.WriteLine($"Undergraduate: {undergrad.name}");
            Console.WriteLine($"Passed: {undergrad.IsPassed(undergrad.grade)}");
            Console.WriteLine($"Graduate: {grad.name}");
            Console.WriteLine($"Passed: {grad.IsPassed(grad.grade)}");

            Console.WriteLine("============Products DETAILS==========");
            Products.product_details();


            Console.WriteLine("============EXCEPTION HANDLING===========");
            Exception_Handing.exception();

            Console.Read();

        }

    }
    public abstract class Student
    {
        public string name;
        public int studentId;
        public double grade;

        public Student(string name, int studentId, double grade)
        {
            this.name = name;
            this.studentId = studentId;
            this.grade = grade;
        }

        public abstract bool IsPassed(double grade);
    }

    public class Undergraduate : Student
    {
        public Undergraduate(string name, int studentId, double grade) : base(name, studentId, grade)
        {
        }

        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    public class Graduate : Student
    {
        public Graduate(string name, int studentId, double grade) : base(name, studentId, grade)
        {
        }

        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }
}

   

    




