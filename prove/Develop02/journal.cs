public class Journal
    {
    public List<Write1> _entrylist = new List<Write1>() {
    };

    public Journal()
    {

    }
    public void Display()
    {

        _entrylist.Reverse();
        Console.Clear();
        foreach(var Entry in _entrylist){
            Entry.display();
        }
        _entrylist.Reverse();
        Console.WriteLine();
        // Console.ReadLine();
    }
    public void Loadentry(List<Write1> entrylist)
    {
      _entrylist = entrylist;

    }

    public List<Write1> getwrite()
    {
      return _entrylist;
    }
    
}