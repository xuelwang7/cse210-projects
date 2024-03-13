public class Lectures:Event
{
//     private string speaker;
//     private int capacity;


    public Lectures(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity,string name): base(title, description, date, time, address, speaker + ", " + capacity, name) {
      //   this.speaker = speaker;
      //   this.capacity = capacity;
      name = "Lectures";
    }

   public override void Details()
   {
     Console.WriteLine($"Title: {Title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()}");
   }

}