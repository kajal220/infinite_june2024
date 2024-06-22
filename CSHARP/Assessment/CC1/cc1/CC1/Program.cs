using System;
using static System.Console;
class Program
{
    static void Main()

    {
        //Program.index_removing();
        //Program.exchange_of_string();
        Program.largest_number();
        //Program.Multiplication();

        Console.Read();

    }
    public static void index_removing()
    {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();

        Console.WriteLine("Enter the index");
        int index = int.Parse(Console.ReadLine());

        string result = RemoveCharAt(str, index);
        Console.WriteLine(result);

    }

    static string RemoveCharAt(string s, int index)
    {

        return s.Remove(index, 1);

    }


    static void exchange_of_string()
    {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();
        string str2 = ExchangeFirstLast(str);
        Console.WriteLine($"Swapping of first and last characters:");
        Console.WriteLine(str2);
    }

    static string ExchangeFirstLast(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length == 1)
        {
            return s;
        }

        char firstChar = s[0];
        char lastChar = s[s.Length - 1];
        return $"{lastChar}{s.Substring(1, s.Length - 2)}{firstChar}";
    }
    public static void Multiplication()
    {

        WriteLine("Enter the number:");
        int num = int.Parse(ReadLine());


        WriteLine($"Multiplication table for {num}:");
        for (int i = 0; i <= 10; i++)
        {
            int result = num * i;
            WriteLine($"{num} * {i} = {result}");

        }
    }
    public static void largest_number()
    {
        WriteLine("Enter the first Number:");
        int num1 = int.Parse(ReadLine());

        WriteLine("Enter the second Number:");
        int num2 = int.Parse(ReadLine());

        WriteLine("Enter the third Number:");
        int num3 = int.Parse(ReadLine());

        int largest = Math.Max(num1, Math.Max(num2, num3));

        WriteLine("The largest number is: " + largest);
    }
}
    







