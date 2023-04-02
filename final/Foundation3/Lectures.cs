public class Lectures:Event
{
//     private string speaker;
//     private int capacity;


    public Lectures(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity,string name): base(title, description, date, time, address, speaker + ", " + capacity, name) {
      //   this.speaker = speaker;
      //   this.capacity = capacity;
      name = "Lectures";
    }

   

}