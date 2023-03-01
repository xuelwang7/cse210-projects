class Listing : Activity
{
    
    
    public Listing(){
        _introduction = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    List<string>_promptListing = new List<string>()
    {
        "--- Who are people that you appreciate?---  ",
        "---What are personal strengths of yours?---",
        "---Who are people that you have helped this week?---",
        "---When have you felt the Holy Ghost this month?---",
        "---Who are some of your personal heroes?---"

    };

    private string _entrylist;

    public string PromptlistSentence()
    {
        int size = _promptListing.Count;
        Random rnd = new Random();
        int RandomIndex = rnd.Next(size);
        string random = _promptListing[RandomIndex];
        Console.WriteLine(random);

        return random;
    }


      public override void doActivity()
      {
        int _entrylist = 0;
        Intro();
        WaitBreathing(3);
        Console.WriteLine("List as many responses you can to the following prompt:");
        PromptlistSentence();
        Console.WriteLine("You may begin in:");
        
        DateTime startTime = DateTime.Now;
        while (DateTime.Now < startTime.AddSeconds(_seconds))
        {
         _entrylist += 1;
         Console.ReadLine();
        }

        countDown(5);
        Console.Write("\b ");
        Console.WriteLine();
        WaitBreathing(1);

        Console.WriteLine($"you have completed {_seconds} seconds.");

        
        Console.WriteLine($"You listed {_entrylist} items");
        Console.WriteLine("Well done!");
    


      }

     
}