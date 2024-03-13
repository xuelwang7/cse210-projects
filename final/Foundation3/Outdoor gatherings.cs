public class Outdoor:Event
{
      // private string weather;

    public Outdoor(string title, string description, DateTime date, TimeSpan time, Address address, string weather)
        : base(title, description, date, time, address,weather,"Outdoor") {
      //   this.weather = weather;
    }


    public override void Details()
   {
    Console.WriteLine($"Title: {Title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()},weather:{additionalInfo}");
   }

    

}