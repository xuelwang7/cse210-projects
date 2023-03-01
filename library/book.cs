public class book : loanable
{
      private string _isbn;
      private string _title;
      private int _upc;

      public book(string title,string isbn, int upc)
      {
            _title = title;
            _upc = upc;
            _isbn = isbn;

      }
      public void showbookDetails()
      {
            Console.WriteLine($"{_title}:{_isbn}{_upc}");
      }

      public override void Display()
      {
            base.Display();
            showbookDetails();
      }

}