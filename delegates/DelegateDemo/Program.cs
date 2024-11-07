using DelegateDemo;
using System;

class Program
{
    static void study_progress(int hours, string subject)
    {
        Console.WriteLine("{0} hours studied for {1} subject",hours,subject);
    }

    static void study_completed(string subject)
    {
        Console.WriteLine("{0} subject study completed",subject);
    }

    static void Main(string[] args)
    {
        study_progress del_stdprg = new study_progress(study_progress);
        study_completed del_stdcmpl = new study_completed(study_completed);

        Student std = new Student();
        std.study(5, "PHYSICS", del_stdprg, del_stdcmpl);

    }
}