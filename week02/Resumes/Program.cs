// ----------------------------------------------
// Dulio Delgado
// W02 Learning Activity: Abstraction
// This program creates a Resume with Job history
// using classes and object-oriented design in C#.
// ----------------------------------------------

using System;
using System.Collections.Generic;

class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

class Resume
{
    public string _name;
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

class Program
{
    static void Main(string[] args)
    {
        // Create first job
        Job job1 = new Job();
        job1._jobTitle = "Project Manager";
        job1._company = "Nokia";
        job1._startYear = 2002;
        job1._endYear = 2005;

        // Create second job
        Job job2 = new Job();
        job2._jobTitle = "Project Manager 2";
        job2._company = "FamilySearch";
        job2._startYear = 2005;
        job2._endYear = 2025;

        // Create resume
        Resume myResume = new Resume();
        myResume._name = "Dulio Delgado";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display resume
        myResume.Display();
    }
}