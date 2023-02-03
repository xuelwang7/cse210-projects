using System;

public class job
    {
      public string _company;
      public string _jobtitle;
      public string _startyear ;
      public string _endyear ;

      public job()
      {      
      }
      public void Display()
      {
            Console.WriteLine($"{_jobtitle}, {_company} {_startyear}-{_endyear}");
      }
      
    }
