using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lectures = new Lectures("American Lectures","talk about the fiction's history",DateTime.Now,TimeSpan.FromDays(2), new Address("400 S.2nd","Rexurg","Idaho",83440),"joe",20,"public speaking");
        Console.WriteLine(lectures.GetStandardDetails());

        Receptions receptions = new Receptions("New Receptions","white",DateTime.Now,TimeSpan.FromDays(4), new Address("400 South Road","Syracus","Newyork",83440),"john1999@gmail.com");
        Console.WriteLine(receptions.GetFullDetails());

        Outdoor outdoor = new Outdoor("Activity","Outdoor drink festival",DateTime.Now,TimeSpan.FromDays(6), new Address("310 East Road","Newyork","Newyork",83440),"Rainning");
        Console.WriteLine(outdoor.ShortDescription());

        // Address address = new Address("","","",3);
        // address.DoSomething(lectures);
    }
}