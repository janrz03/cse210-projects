using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int num = -1;

        while(num != 0)
        {
            Console.Write("Please enter a number (press 0 to quit): ");
            
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                numbers.Add(num);
            }
        }
        // 1. Compute the sum, or total, of the numbers in the list.

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is equal to: {sum}");
        // 2.Compute the average of the numbers in the list.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // 3.Find the maximum, or largest, number in the list.
        int max = 0;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max number is: {max}");
    }
    

}