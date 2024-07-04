using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cricket
{
    public void PointsCalculation(int no_of_matches)
    {
        int[] scores = new int[no_of_matches];
        int sum = 0;

        for (int i = 0; i < no_of_matches; i++)
        {
            Console.Write($"Enter score for match {i + 1}: ");
            scores[i] = Convert.ToInt32(Console.ReadLine());
            sum += scores[i];
        }
        double average = (double)sum / no_of_matches;
        Console.WriteLine($"Total sum of scores: {sum}");
        Console.WriteLine($"Average score: {average}");
    }
}

class Program
{
    public static void Main(String[] args)
    {
        Cricket cricket = new Cricket();
        Console.Write("Enter the number of matches: ");
        int no_of_matches = Convert.ToInt32(Console.ReadLine());
        cricket.PointsCalculation(no_of_matches);
    

        Console.WriteLine("=======COMBINED BOXES DETAILS=======");

        Test.dimensions_of_box();
        Console.Read();
    }
}
