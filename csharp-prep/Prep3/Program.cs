using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?");
        int userinput = int.Parse(Console.ReadLine());
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
    
        bool guessed = false ;
        int turns = 0;
        while (guessed == false)
        {    
            Console.Write("please enter your guess:");
            int answer = int.Parse(Console.ReadLine());
            turns += 1;

            if (answer > number)
            {
                Console.WriteLine("Lower");
            }
            else if(answer < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Great!");
                guessed = true;
            }
        }
        Console.WriteLine($"it tooks you {turns} turns to guess the number.");
        

    }
}