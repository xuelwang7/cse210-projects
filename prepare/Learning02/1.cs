using System;

public class Resume
{
    public string _name;
    public string job;

    // Make sure to initialize your list to a new List before you use it.
    public List<string> _jobs = new List<string>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (string job in _jobs)
        {
            // This calls the Display method on each job
            
        }
    }
}
