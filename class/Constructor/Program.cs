using System;

class Triangle
{
    public double b;
    public double h;

    public double calc_area()
    {
        return 0.5 * (this.b * this.h);
    }

    public Triangle()
    {
        Console.WriteLine("default constructor initialized");
    }

    static Triangle() 
    {
        Console.WriteLine("static constructor initialized");
    }

    ~Triangle()
    {
        Console.WriteLine("destructor called");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Triangle trg=new Triangle();
        trg.b = 4.5;
        trg.h = 3.5;

        Console.WriteLine("Triangle area: " + trg.calc_area());
    }
}