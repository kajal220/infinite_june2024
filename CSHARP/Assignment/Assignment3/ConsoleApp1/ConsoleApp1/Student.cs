using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3

{
        public class Student
        {
            public int rollNo;
            public string name;
            public string studentClass;
            public string semester;
            public string branch;
            public int[] marks = new int[5];
            int sum = 0;

            public Student(int rollNo, string name, string studentClass, string semester, string branch)
            {
                this.rollNo = rollNo;
                this.name = name;
                this.studentClass = studentClass;
                this.semester = semester;
                this.branch = branch;
            }

            public void GetMarks()
            {
              

                for (int i = 0; i < marks.Length; i++)
                {
                    Console.Write($"Enter marks for Subject {i + 1}: ");
                    marks[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            public int CalculateAverageMarks()
            {
                foreach (int mark in marks)
                {
                    sum += mark /5;
                }

                return sum;
            }
        public void DisplayResult()
        {
            int averageMarks = CalculateAverageMarks();
            int fail = 0;

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < 35)
                {
                    fail++;
                }
            }

            if (fail < 0)
            {
                Console.WriteLine("Result: Failed");
            }
            else
            {
                if (averageMarks < 50)
                {
                    Console.WriteLine("Result: Failed");
                }
                else
                {
                    Console.WriteLine("Result: Passed");
                }
            }
        }
        public void DisplayData()
            {
                Console.WriteLine($"Roll No: {rollNo}");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Class: {studentClass}");
                Console.WriteLine($"Semester: {semester}");
                Console.WriteLine($"Branch: {branch}");
                Console.WriteLine("Marks:");

                for (int i = 0; i < marks.Length; i++)
                {
                    Console.WriteLine($"Subject {i + 1}: {marks[i]}");
                }
            }

        public static void stud()
        {
           
            Console.WriteLine("Enter student details:");

            Console.Write("Roll No.: ");
            int rollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Class: ");
            string studentClass = Console.ReadLine();

            Console.Write("Semester: ");
            string semester = Console.ReadLine();
            Console.Write("Branch: ");
            string branch = Console.ReadLine();
            Student student1 = new Student(rollNo, name, studentClass, semester, branch);
            student1.GetMarks();
            Console.WriteLine("\nStudent Details:");
            student1.DisplayData();
            student1.DisplayResult();
        }

    }
}

    

