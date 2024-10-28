using System;

class Student
{
    private string name;
    private int age;

    public void setName(string name)
    {
        if (string.IsNullOrEmpty(name) == true)
        {
            Console.WriteLine("Name cannot be empty");
        }
        else
        {
            this.name = name;
        }
    }

    public void getName()
    {
        if(string.IsNullOrEmpty(this.name) == true) { }
        else
        {
            Console.WriteLine("Full name: " + this.name);
        }
        
    }

    public void setAge(int age)
    {
        if (age > 0)
        {
            this.age = age;
        }
        else
        {
            Console.WriteLine("Age cannot be 0 or negative");
        }
        
    }

    public void getAge()
    {
        if (this.age > 0) 
        {
            Console.WriteLine("Age: " + this.age);
        }
        else { }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student std = new Student();
        std.setName("Ram Sharma");
        std.getName();
        std.setAge(10);
        std.getAge();   
    }
}