public class Activity
{
      public string _introduction = "";
      public string _inputBreath = "";

      public int _seconds;
      public virtual void doActivity()
      {
      }
      public void Intro()
      {
            Console.WriteLine($"{_introduction}");
            Console.WriteLine("How long, in seconds, would you like for your session?");
            _seconds = int.Parse(Console.ReadLine());
            Console.WriteLine("Get ready...");
            
      }
      public void WaitBreathing(int howLong)
      {
            for (int i =0; i < howLong; i++){
            // while(true){
                  Console.Write("/");
                  Thread.Sleep(500);
                  Console.Write("\b"); 
                  
                  Console.Write("|");
                  Thread.Sleep(500);
                  Console.Write("\b"); 
            
                  Console.Write("\\");
                  Thread.Sleep(500);
                  Console.Write("\b\b"); 
                  
                  Console.Write("-");
                  Thread.Sleep(500);
                  Console.Write("\b");
            }
      }
      
      public void countDown(int time)
      {
            for (int i = time; i > 0; i--)
            {
            Console.Write("\b"); // Erase the + character

            Console.Write($"{i}");

            Thread.Sleep(1000);
                  
            }

      }
      


}