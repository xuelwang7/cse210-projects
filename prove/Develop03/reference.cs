public class Reference{
      private string _book;

      private int _chapter;

      private int _verse;

      public Reference(string book,int chapter,int verse)
      {
            _book = book;
            _chapter = chapter;
            _verse = verse;
      }

      public void displayReference()
      {
            Console.WriteLine($"{_book}:{_chapter},{_verse}");
      }


}