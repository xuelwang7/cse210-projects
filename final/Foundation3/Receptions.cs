public class Receptions:Event
{
      // private string Email;

    public Receptions(string title, string description, DateTime date, TimeSpan time, Address address, string Email): base(title, description, date, time, address,Email,"Receptions") 
    {
      //   this.Email = Email;
    }


    public override void Details()
   {
    Console.WriteLine($"Title: {Title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()},E-MAIL:{additionalInfo}");
    
   }

    

}