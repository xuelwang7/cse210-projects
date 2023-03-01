public class Breathing : Activity
{

      public Breathing()
      {
            _introduction = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
      }
      public void userentry(string inputbreath)
      {
            _inputBreath = inputbreath;
           

      }

      
      public override void doActivity()
      {
            Intro();
            WaitBreathing(3); 


            DateTime startTime = DateTime.Now;

            while (DateTime.Now < startTime.AddSeconds(_seconds))
            {
            Console.Write("Breathe in...");
            countDown(6);
            Console.Write("\b "); 

            Console.WriteLine();

            Console.Write("Breathe out...");

            // Thread.Sleep(2000);

            countDown(4);

            Console.Write("\b "); 

            Console.WriteLine();
            }


            Console.WriteLine($"you have completed{_seconds} seconds.");

            WaitBreathing(3);
      }
}