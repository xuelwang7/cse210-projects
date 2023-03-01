using System;

class Program
{
    static void Main(string[] args)
    {
       string userinput = "";
        Breathing breathing = new Breathing();
        Reflecting reflecting = new Reflecting();
        Listing listing = new Listing();

        while(userinput != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Start breathing activity");
            Console.WriteLine("2.Start reflecting activity");
            Console.WriteLine("3.Start listing activity");
            Console.WriteLine("4.Quit");
            Console.Write("Select a choice from the menu :");

            userinput = Console.ReadLine();

            

            if (userinput == "1")
            {
              
              breathing.doActivity(); 
              
            }
            else if (userinput == "2")
            {
               reflecting.doActivity();
            }
            else if (userinput == "3")
            {
                listing.doActivity();
            }
           }
    }
}