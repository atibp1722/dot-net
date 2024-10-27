using System;

public class Student
{
    public int id;
    public string name;
    public string course;
    public int enroll_year;

    public void StudentDetails()
    {
        Console.WriteLine(name+", "+course);
    }

}

public class WorkingStudent: Student
{
    public string company;
    public string status;
    public float salary;

    public void WorkingDetail()
    {
        Console.WriteLine(company+" "+status+" "+salary);
    }
}

public class FullTimeStudent: Student
{
    public string status;
    public float tuition;

    public void FullTimeDetail()
    {
        Console.WriteLine(status+" "+ tuition);
    }
}

class Program
{
    static void Main(string[] args)
    {
        FullTimeStudent fts = new FullTimeStudent();
        fts.id = 100;
        fts.name = "Ram Karki";
        fts.course = "mathematics";
        fts.enroll_year = 2022;
        fts.status = "student";
        fts.tuition = 8500.125f;
        fts.StudentDetails();
        fts.FullTimeDetail();

        WorkingStudent ws = new WorkingStudent();
        ws.id = 110;
        ws.name = "Geeta Sharma";
        ws.course = "economics";
        ws.enroll_year = 2021;
        ws.status = "working";
        ws.company = "SCB";
        ws.salary = 28000;
        ws.StudentDetails();
        ws.WorkingDetail();
    }
}