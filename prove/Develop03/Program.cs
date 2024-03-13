using System;

class Program
{
    static void Main(string[] args)
    {
        
        // word word1 = new word();
        Reference referencenew = new Reference("please type ","Old Testament",1,12);
        scripture scripturenew = new scripture();
        
        string steps = "";

        // while(steps == ""&&scripturenew.numbers.Count()!= 0)
        while(steps == "" && scripturenew.HasNumbersLeft())
        //steps == "": This checks if the steps string is empty.
        // instance of the Scripture class. If there are numbers left in the scripturenew object's numbers list, this method will return true, otherwise it'll return false.
        //Logical AND (&&):The && operator is a logical AND.
        // It evaluates to true only if both conditions on its left and right are true. 
        //If either or both are false, then the whole expression evaluates to false.
        //If either of these conditions becomes false, the loop will exit.
        {
            if (steps != "quit") 
            {
                
                referencenew.displayReference();
                //will display Console.WriteLine($"{_book}:{_chapter},{_verse}"); from reference class
                
                scripturenew.Display();
                scripturenew.scriptureRandom();
                //will display  word.Displayword(); in scripture class
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