using System;

class Student
{
    private string name;
    private int duration;
    private string course;

    public Student(string name, int duration, string course)
    {
        this.name = name;
        this.duration = duration;
        this.course = course; 
    }

    public Student(Student obj)
    {
        this.name = obj.name;
        this.duration = obj.duration;
        this.course = obj.course;
    }

    public string get_student_info
    {
        get { return "Full name: " + this.name + ", course is: " + this.course + " and duration: " + this.duration + " years".ToString(); }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Student std = new Student("Ram Karki",2,"BScIT");
        Student std1 = new Student(std);
        
        Console.WriteLine(std.get_student_info);
        Console.WriteLine(std1.get_student_info);
    }
}