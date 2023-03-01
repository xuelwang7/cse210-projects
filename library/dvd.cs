public class dvd : loanable

{
      private int _number;
      private string _title1;
      

      public dvd(string title1,int number)
      {
            _title1 = title1;
            _number = number;
            

      }
      public void showdvdDetails()
      {
            Console.WriteLine($"{_title1}:{_number}");
      }



}