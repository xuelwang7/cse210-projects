using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lectures = new Lectures("American Lectures","talk about the fiction's history",DateTime.Now,TimeSpan.FromDays(2), new Address("400 S.2nd","Rexurg","Idaho",83440),"joe",20,"public speaking");
        lectures.Details();

        Receptions receptions = new Receptions("New Receptions","white",DateTime.Now,TimeSpan.FromDays(4), new Address("400 South Road","Syracus","Newyork",83440),"john1999@gmail.com");
        receptions.Details();

        Outdoor outdoor = new Outdoor("Activity","Outdoor drink festival",DateTime.Now,TimeSpan.FromDays(6), new Address("310 East Road","Newyork","Newyork",83440),"Rainning");
        outdoor.Details();

        // Address address = new Address("","","",3);
        // address.DoSomething(lectures);
    }
}