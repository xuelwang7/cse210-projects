using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int>numbers = new List<int>();
        int innumber = -1;
        while (innumber !=0)
        {
            Console.Write("Enter number: ");
            string answer = Console.ReadLine();
            innumber = int.Parse(answer);

            if (innumber != 0)
            {
                numbers.Add(innumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += innumber;
        }
        Console.WriteLine($"The sum is{sum}");

        float average = ((float)sum)/ numbers.Count;
        Console.WriteLine($"The average is:{average}");

        int maxnum = numbers[0];
        foreach(int number in numbers)
        {
            if(number > maxnum)
            {
                maxnum =number;
            }
        }
        Console.WriteLine($"The largest number is:{maxnum}");
    }
}