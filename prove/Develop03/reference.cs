
using System.Collections.Generic;
public class Reference{
      private string _book;

      private int _chapter;

      private int _verse;

      private string _instruction;

      public Reference(string instruction,string book,int chapter,int verse)
      {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _instruction = instruction;
      }

      public void displayReference()
      {
            Console.WriteLine($"{_instruction},{_book}:{_chapter},{_verse}");
            
      }


}