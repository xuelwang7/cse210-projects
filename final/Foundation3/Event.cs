public abstract class Event
{
  private string Title;
  private string description; 
  private DateTime date;
  private TimeSpan time;
  
  private Address address;

  private string additionalInfo;

  private string name;


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

    public string GetStandardDetails() 
    {
        return $"Title: {Title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()}";
    }

    public string GetFullDetails()
    {
      return $"Title: {Title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()},E-MAIL:{additionalInfo}";
    }

    public string ShortDescription()
    {
      return $"Title: {Title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()},weather:{additionalInfo}";
    }


    


}