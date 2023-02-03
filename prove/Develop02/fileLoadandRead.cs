using System;
public class FileLoadRead{
private string _fileName1 = "journal.txt";

    public void writefile(List<Write1> entrylist){
      string filename = promptfile($"what is the file name?");
      using (StreamWriter outputFile = new StreamWriter(_fileName1))
      foreach (var entry in entrylist){
        
        outputFile.WriteLine(entry.something());

      }
    }
    public string promptfile(string promptquestion){
      Console.Write(promptquestion);
      string filename = Console.ReadLine();
      filename = "journal.txt";
      return filename;    
    }

    public List<Write1>readFile()
    {
      string filename = promptfile($"what is the file name?");;
      string[] lines = System.IO.File.ReadAllLines(filename);
      List<Write1>entrylist = new List<Write1>();

        foreach (string line in lines)
        {
        string[] parts = line.Split(",");
        Write1 write = new Write1();
        write.creatlist(parts);
        entrylist.Add(write);
        
        }
        return entrylist;

    }
}