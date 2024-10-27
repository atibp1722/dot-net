using System;

//single inheritance
public class Parent
{
    public Parent()
    {
        Console.WriteLine("This is parent class");
    }

    public Parent(string greet)
    {
        Console.WriteLine(greet);
    }
}

public class Child : Parent
{
    public Child() : base("Parent from child class")
    {
        Console.WriteLine("This is child class");
    }

}

//heirarchial inheritance
public class Parents
{
    public Parents()
    {
        Console.WriteLine("parent called");
    }
}

public class Son : Parents
{
    public Son()
    {
        Console.WriteLine("Son class called");
    }
}
public class Daughter : Parents
{
    public Daughter()
    {
        Console.WriteLine("Daughter class called");
    }
}

//multi-level inheritance
public class Grandmothers
{
    public void base_method() 
    {
        Console.WriteLine("this is base class method");
    }
}

public class Mothers: Grandmothers
{
    public void inter_method()
    {
        Console.WriteLine("intermediate class method");
    }
}

public class Daughters: Mothers
{
    public void child_method()
    {
        Console.WriteLine("child class method");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Parent prt = new Parent();
        Child child = new Child();
        Console.WriteLine();

        Son son = new Son();
        Daughter dtr = new Daughter();
        Console.WriteLine();

        Daughters dtrs=new Daughters();
        dtrs.base_method();
        dtrs.inter_method();
        dtrs.child_method();
    }
}