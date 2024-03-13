using System.Collections.Generic;

public class scripture{

      

      private string _scriptures = "And God created great whales, and every living creature that moveth, which the waters brought forth abundantly, after their kind, and every winged fowl after his kind: and God saw that it was good.";
      private List<Word> _words = new List<Word>();

      
      private List<int> numbers = new List<int>();

      public scripture()
      {
            string[] words = _scriptures.Split(" ");
            int count1 = 0;
            foreach (string word in words)
            {
                  _words.Add(new Word(word));
                  numbers.Add(count1);
                  count1 += 1;

            }
            
      }
      public bool HasNumbersLeft()
      {
            return numbers.Count > 0;
            //If there's at least one number in the list,
            // this expression evaluates to true, 
            //otherwise false.
      }
      //the method will check 
      //if there are any numbers left in the numbers list


      public void scriptureRandom(){
            
            int size = numbers.Count;
            Random rd = new Random();
            int randomIndex = rd.Next(size);
      
            
            if (numbers.Count!= 0)
            {
                  
                  _words[numbers[randomIndex]] = new Word("__");
                  numbers.RemoveAt(randomIndex);

            }
            
            
      }

      public void Display(){
            Console.WriteLine();
            foreach (Word word in _words) {
                  word.Displayword();
            }

      }
}