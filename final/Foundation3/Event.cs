public abstract class Event
{
  protected string Title;
  protected string description; 
  protected DateTime date;
  protected TimeSpan time;
  
  protected Address address;

  protected string additionalInfo;

  protected string name;


  public Event(string title, string description, DateTime date, TimeSpan time, Address address,string additionalInfo, string name) 
  {
        
        this.Title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
        this.additionalInfo= additionalInfo;
        this.name = name;
    }

    public abstract void Details();

    // public string GetStandardDetails() 
    // {
    //     return $"Title: {Title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()}";
    // }

    // public string GetFullDetails()
    // {
    //   return $"Title: {Title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()},E-MAIL:{additionalInfo}";
    // }

    // public string ShortDescription()
    // {
    //   return $"Title: {Title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()},weather:{additionalInfo}";
    // }


    


}