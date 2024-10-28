using System;

abstract class Person
{
    public string name;
    public int age;
    public string address;
    public long contact;

    public abstract void display();
}

class Student: Person
{
    public int sid;
    public string course;
    public int fees;

    public override void display()
    {
        string name = this.name;
        Console.WriteLine("Student name: {0}",name);
        Console.WriteLine("Student age: {0}",this.age);
        Console.WriteLine("Student contact: {0},"+" {1}",this.address,this.contact);
        Console.WriteLine("Student ID: {0}" + " enrolled in: {1}"+" total fees: {2}", 
            this.sid, this.course, this.fees);
    }
}

class Faculty: Person
{
    public int salary;
    public string dept;

    public override void display()
    {
        Console.WriteLine("Faculty name: {0}", this.name);
        Console.WriteLine("Faculty age: {0}", this.age);
        Console.WriteLine("Faculty contact: {0}," + " {1}", this.address, this.contact);
        Console.WriteLine("Faculty is paid: {0}" + " belongs to: {1}", this.salary, this.dept);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student std = new Student();
        std.name = "Geeta Sharma";
        std.age = 28;
        std.address = "Lalitpur";
        std.contact = 9851098510;
        std.sid = 100;
        std.course = "Computer Science";
        std.fees = 250000;
        std.display();

        Console.WriteLine();

        Faculty fcl = new Faculty();
        fcl.name = "Rama KC";
        fcl.age = 38;
        fcl.address = "Pokhara";
        fcl.contact = 9841109956;
        fcl.dept = "Engineering";
        fcl.salary = 42500;
        fcl.display();
    }
}