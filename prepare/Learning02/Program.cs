using System;
using Learning02;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job
        {
            _company = "Amazon",
            _jobTitle = "Software Engineer",
            _startYear = 2010,
            _endYear = 2022
        };

        Job job2 = new Job
        {
            _company = "BYU",
            _jobTitle = "Data Scientist",
            _startYear = 2015,
            _endYear = 2024
        };

        Resume resume1 = new Resume{
            _name = "Karina Felippe"
        };
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}