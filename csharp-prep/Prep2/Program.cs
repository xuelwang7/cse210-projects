using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score?");
        string userinput = Console.ReadLine();
        int n = int.Parse(userinput);
        
        string letter = "";

        if (n >= 90)
        {
            letter ="A";
        }
        else if (n >= 80)
        {
            letter ="B";
        }
        else if (n >= 70)
        {
            letter ="C";
        }
        else if (n >= 60)
        {
            letter ="D";
        }
        else 
        {
            letter ="F";
        }

        Console.WriteLine($"Your letter is {letter}");
        
        Console.Write("what is your letter grade?");
        string grade = Console.ReadLine();
        if (grade =="A" || grade == "B" || grade == "C")
        {
            Console.WriteLine("Congratulation! You pass the class!");
        }
        else
        {
            Console.WriteLine("Take it again.");
        }


    }
}