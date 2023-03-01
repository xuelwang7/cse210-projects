public class loanable
{
      
      
      private bool _ischeckin = true;

      public void checkout()
      {
            _ischeckin = false;

      }

      public void checkin()
      {
            _ischeckin = true;
      }

      public virtual void Display()
      {
            Console.WriteLine($"Available:{_ischeckin}");
      }

}