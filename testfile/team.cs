public class team{
      private string _name;
      private List<player> _player = new List<player>();

      private int _win = 0;
      private int _lost = 0;


      public team(string name){
            _name = name;
      }


      public  void addplayer(player p)
      {
            _player.Add(p);

      }

      public void displayPlayer()
      {
            Console.Clear();
            Console.WriteLine(_name);
            Console.WriteLine($"wins{_win},{_lost}");
            Console.WriteLine(".....................");


            foreach(player p in _player) 
            {
                  p.Display();

            }
            Console.WriteLine();
      }

      public void Addwin()
      {
            _win += 1;
      }
      public void Addlost()
      {
            _lost += -1;
      }

      public string GetTeamname()
      {
            return _name;
      }
}