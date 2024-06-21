using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Greater_than_less_than
    {
    public static void Test()
    {
        Console.Write("Enter the First Integer: ");
        int firstnumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the Second Integer: ");
        int secondnumber = int.Parse(Console.ReadLine());

        if (firstnumber == secondnumber)
        {
            Console.WriteLine("Two integers are equal");
        }
        else
        {
            Console.WriteLine("Two integers are not equal");
        }
        Console.Read();
    }
    }

