class Reflecting : Activity {

      public string _intro;

      public string _sentence;



public Reflecting()
      {
             _introduction ="This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
      }
public void entrysomething(string intro, string sentence)
      {
            _intro = intro;
            _sentence = sentence;
      }
           

 
      List<string>intro = new List<string>(){
        "--- Think of a time when you stood up for someone else.--- ",
        "--- Think of a time when you did something really difficult.--- ",
        "--- Think of a time when you helped someone in need.--- ",
        "--- Think of a time when you did something truly selfless.--- "
    };
    List<string>sentence = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"

    };
    public string PromptIntro(){

            int size = intro.Count;
            Random rnd = new Random();
            int randIndex = rnd.Next(size);
            string random = intro[randIndex];
            Console.WriteLine(random);
            return random;
        }
      
      public string PromptSentence()
   {
            int size = sentence.Count;
            Random rnd = new Random();
            int randIndex = rnd.Next(size);
            string random2 =sentence[randIndex];
            Console.WriteLine(random2);
            return random2;
   }


      public void ShowReflecting()
      {
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine($"{_intro}");


      }
     
      public override void doActivity()
      {     
            Intro();
            WaitBreathing(6);
            ShowReflecting();
            PromptIntro();
            Console.WriteLine("when you have some thing in mind, press enter to continue");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they ralated to this experience ");
            
            
            DateTime startTime = DateTime.Now;
            if (DateTime.Now < startTime.AddSeconds(_seconds))
            {
            Console.WriteLine("You may begin in:");
            countDown(5);
            Console.Write("\b "); 
            PromptSentence();
            WaitBreathing(4);
            PromptSentence();
            WaitBreathing(4);
            Console.WriteLine("Well done!");
            WaitBreathing(2);
            }

            Console.WriteLine($"you have completed {_seconds} seconds.");

      }
}