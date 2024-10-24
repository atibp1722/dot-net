using System;

class Program
{
    static void Main(string[] args)
    {
        //instance method called by instance of the class
        Program prg = new Program();
        prg.numbers();

        //static method called by class name itself
        Program.number();

        //calling parameterized method
        Program prg1 = new Program();
        prg1.nums(15);

        Program prg2 = new Program();
        Console.WriteLine(prg2.add(10, 20));
    }

    //instance method
    public void numbers()
    {
        int f = 0;
        while (f <= 10)
        {
            Console.Write(f+" ");
            f += 2;
        }
        Console.WriteLine();
    }

    //static method
    public static void number()
    {
        int f = 1;
        while (f <= 10)
        {
            Console.Write(f+" ");
            f += 2;
        }
    }

    //parameterized method
    public void nums(int n)
    {
        int f = 1;
        while (f <= n)
        {
            Console.Write(f + " ");
            f += 2;
        }
        Console.WriteLine();
    }

    public int add(int a, int b)
    {
        return a + b;
    }
}