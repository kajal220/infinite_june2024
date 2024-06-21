using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
    {
        class Program
        {
            static void Main(string[] args)
            {
                Program.Summation();
                Program.f1();
               // Program.Marks();
                //Program.Array_1();
                //Program.Length_of_word();
                //Program.Reverse_word();
                //Program.Check_Word();
               // Program.Days_week();
                Console.Read();
            }
        
        public static void f1()
        {
            int[] array = { 3, 9, 4, 1, 7, 2, 8, 5, 6 };

            double average = CalculateAverage(array);
            Console.WriteLine($"Average value of array elements: {average}");


            int minimum = FindMinimum(array);
            int maximum = FindMaximum(array);
            Console.WriteLine($"Minimum value in the array: {minimum}");
            Console.WriteLine($"Maximum value in the array: {maximum}");
        }
        static double CalculateAverage(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array must not be empty.");
            }

            double sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }

            return sum / array.Length;
        }


        static int FindMinimum(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array must not be empty.");
            }

            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }


        static int FindMaximum(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array must not be empty.");
            }

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
        public static void Check_Word()
        {

            Console.Write("Enter the first word: ");
            string word1 = Console.ReadLine();

            Console.Write("Enter the second word: ");
            string word2 = Console.ReadLine();


            bool areSame = string.Equals(word1, word2, StringComparison.OrdinalIgnoreCase);

            if (areSame)
            {
                Console.WriteLine($"The words '{word1}' and '{word2}' are the same.");
            }
            else
            {
                Console.WriteLine($"The words '{word1}' and '{word2}' are different.");
            }
        }
        public static void Array_1()
        {

            int[] sourceArray = { 1, 2, 3, 4, 5 };


            int[] destinationArray = new int[sourceArray.Length];

            for (int i = 0; i < sourceArray.Length; i++)
            {
                destinationArray[i] = sourceArray[i];
            }

            Console.WriteLine("Elements copied from sourceArray to destinationArray:");
            foreach (int num in destinationArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static string GetDayName(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    return null;
            }
        }

        public static void Days_week()
        {
            Console.Write("Enter a day number (1-7): ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            string dayName = GetDayName(dayNumber);

            if (dayName != null)
            {
                Console.WriteLine($"The day corresponding to {dayNumber} is {dayName}.");
            }
            else
            {
                Console.WriteLine("Invalid day number. Please enter a number between 1 and 7.");
            }
        }
        public static void Reverse_word()
        {

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            string reversedWord = ReverseString(word);


            Console.WriteLine($"Reverse of the word '{word}' is: {reversedWord}");
        }

        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static void Summation()
        {
            Console.Write("Enter the first no ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second no ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            if (num1 == num2)
            {
                sum *= 3;
            }

            Console.WriteLine(sum);

        }
        public static void Length_of_word()
        {

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            int length = word.Length;
            Console.WriteLine($"Length of the word '{word}' is: {length}");
        }
        public static void Marks()
        {
            int[] marks = new int[10];


            Console.WriteLine("Enter ten marks:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }


            int total = CalculateTotal(marks);
            Console.WriteLine($"Total marks: {total}");


            double average = CalculateAverage(marks);
            Console.WriteLine($"Average marks: {average:F2}");

            int minimum = FindMinimum(marks);
            int maximum = FindMaximum(marks);
            Console.WriteLine($"Minimum marks: {minimum}");
            Console.WriteLine($"Maximum marks: {maximum}");

            int[] ascendingOrder = SortAscending(marks);
            Console.WriteLine("Marks in ascending order:");
            DisplayMarks(ascendingOrder);

            int[] descendingOrder = SortDescending(marks);
            Console.WriteLine("Marks in descending order:");
            DisplayMarks(descendingOrder);
        }


        static int CalculateTotal(int[] marks)
        {
            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            return total;
        }


        static double CalculateAvg(int[] marks)
        {
            int total = CalculateTotal(marks);
            return (double)total / marks.Length;
        }

        static int FindMin(int[] marks)
        {
            int min = marks[0];
            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] < min)
                {
                    min = marks[i];
                }
            }
            return min;
        }

        static int FindMax(int[] marks)
        {
            int max = marks[0];
            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] > max)
                {
                    max = marks[i];
                }
            }
            return max;
        }

        static int[] SortAscending(int[] marks)
        {
            int[] ascendingOrder = new int[marks.Length];
            Array.Copy(marks, ascendingOrder, marks.Length);
            Array.Sort(ascendingOrder);
            return ascendingOrder;
        }


        static int[] SortDescending(int[] marks)
        {
            int[] descendingOrder = new int[marks.Length];
            Array.Copy(marks, descendingOrder, marks.Length);
            Array.Sort(descendingOrder);
            Array.Reverse(descendingOrder);
            return descendingOrder;
        }

        static void DisplayMarks(int[] marks)
        {
            foreach (int mark in marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
    }
}
    
    
    

    


    

        
