using System;
using System.ComponentModel;

class Program
{
    public void add()
    {
        int a=5, b=10;
        int c = a + b;
        Console.WriteLine(c);
    }
    public void add(int a, int b)
    {
        int c = a + b;
        Console.WriteLine(c);
    }
    public void add(string a, string b)
    {
        string c = a+" "+b;
        Console.WriteLine(c);
    }
    public void add(float a, float b)
    {
        float c = a + b;
        Console.WriteLine(c);
    }
    public static void Main(string[] args)
    {
        Program prg = new Program();
        prg.add();
        prg.add(10, 20);
        prg.add("hello", "world");
        prg.add(5.65f, 2.75f);
    }
}