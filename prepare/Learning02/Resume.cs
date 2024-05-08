using System;

public class Resume
{
    public string _name;
    //We initialize List<Job> immediately so when call _jobs there is no further complications.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}