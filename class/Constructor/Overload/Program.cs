using System;

class Program
{
    public static void Main(string[] args)
    {
        add(10,20);
        add(5.7, 2.9);
        add(57,29,32);
        add(25, 25);
    }

    public static void add(int x, int y)
    {
        Console.WriteLine("Sum of {0},{1} = {2}",x,y,x+y);
    }

    public static void add(double x, double y)
    {
        Console.WriteLine("Sum of {0}, {1} = {2}", x, y, x + y);
    }

    public static void add(int x, int y, int z)
    {
        Console.WriteLine("Sum of {0},{1},{2} = {3}", x, y, z, x+ y+z);
    }

    public static void add(int x, int y, out int sum)
    {
        Console.WriteLine("Sum of {0},{1} = {2}", x, y, x + y);
        sum= x + y;
    }
}