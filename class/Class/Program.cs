using System;

class Employee
{
    string fname;
    string lname;
    int salary;

    public Employee() : this("NA","NA",0)
    {
    }

    public Employee(string fname, string lname, int salary)
    {
        this.fname = fname;
        this.lname = lname;
        this.salary = salary;
    }

    public void full_details()
    {
        Console.WriteLine("Full name: "+this.fname+" "+this.lname+", salary: "+this.salary);
    }
}

class Program
{
    static void Main(string[] args) 
    {
        Employee emp = new Employee("Ram","Karki", 25000);
        emp.full_details();

        Employee emp2 = new Employee();
        emp2.full_details();
    }
}