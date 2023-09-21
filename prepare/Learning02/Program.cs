using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Serasa Experian";
        job1._jobTitle = "Backoffice Agent";
        job1._startYear = 2021;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "São Carlos Marklin Suítes";
        job2._jobTitle = "Recepcionista";
        job2._startYear = 2020;
        job2._endYear = 2021;
        
        Resume myResume = new Resume();
        myResume._name = "Carlos Machado";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayJobs();

    }
}