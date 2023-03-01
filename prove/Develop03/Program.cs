using System;

class Program
{
    static void Main(string[] args)
    {
        
        // word word1 = new word();
        Reference referencenew = new Reference("Old Testament",1,12);
        scripture scripturenew = new scripture();
        
        string steps = "";

        while(steps == ""&&scripturenew.numbers.Count()!= 0)
        {
            if (steps != "quit") 
            {
        
                referencenew.displayReference();
                scripturenew.scriptureRandom();
                scripturenew.Display();
                steps = Console.ReadLine();
                Console.Clear();
           
            }
            else
            {
                steps = "quit";
            }

        }

    }
}