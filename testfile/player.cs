public class player{
      private string _name;
      private int _number;

      public player(string name,int number)
      {
            _name = name;
            _number = number;


      }
      public void Display()
      {
            Console.WriteLine($"{_name},{_number}");

      }
}