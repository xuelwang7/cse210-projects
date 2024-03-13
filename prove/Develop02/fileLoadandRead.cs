using System;
public class FileLoadRead{
    // private string _fileName1 = "journal.txt";
    
    List<Write1>entrylist = new List<Write1>();
    //from write class set the entry prompt and date 
    
    public void writefile(List<Write1> entrylist){
      string filename = promptfile($"what is the file name?");
      using (StreamWriter outputFile = new StreamWriter(filename))
      foreach (var entry in entrylist){
        
        outputFile.WriteLine(entry.something());

      }//using the something method from the Write1 class, 
      //which formats the entry as a CSV line.
    }
    public string promptfile(string promptquestion){
      Console.Write(promptquestion);
      //displays a prompt to the user
      string filename = Console.ReadLine();
      // and reads a line from the console
      return filename;    
    }

    public List<Write1>readFile()
    {
      string filename = promptfile($"what is the file name?");;
      string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
        string[] parts = line.Split(",");
        Write1 write = new Write1();
        write.creatlist(parts);
        entrylist.Add(write);
        
        }
        return entrylist;
//uses the creatlist method of Write1 
//to initialize a new Write1 object with the data from the line. 
    }
}
// public void creatlist(string[] entrysomething){
//                 _date = entrysomething[0];
//                 _prompt = entrysomething[1];
//                 _entry = entrysomething[2];
//         }