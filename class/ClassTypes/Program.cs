using System;
using System.Runtime.CompilerServices;

class Cylinder
{
    //float pi = 3.14159f
    static float pi;
    int radius;
    int height;

    public Cylinder(int r, int h)
    {
        this.radius = r;
        this.height = h;
    }

    static Cylinder()
    {
        Cylinder.pi = 3.14159f;
    }

    /*
    public static void calculate_diameter()
    { }
    */

    public float calculate_area() 
    {
        //return 2 * this.pi * this.radius * (this.radius + this.height);
        return 2*Cylinder.pi*this.radius*(this.radius+this.height);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cylinder cyl1 = new Cylinder(3, 5);
        float area = cyl1.calculate_area();
        Console.WriteLine("Cylinder area: "+area);

        //Cylinder.calculate_diameter();
    }
}