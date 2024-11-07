using System;

public delegate void callDelegate(int a, int b);

class Program
{

    public static void multiply(int a, int b) 
    {
        int result = a * b;
        Console.WriteLine("Result mul: {0}",result);
    }

    public static void divide(int a, int b)
    {
        int result = a / b;
        Console.WriteLine("Result div: {0}", result);
    }

    public static void add(int a, int b)
    {
        int result = a + b;
        Console.WriteLine("Result add: {0}", result);
    }

    public static void subtract(int a, int b)
    {
        int result = a - b;
        Console.WriteLine("Result sub: {0}", result);
    }

    static void Main(string[] args)
    {
        //delegate from object(can be done separately for each method) needs to be done using invoke
        callDelegate cd = new callDelegate(Program.multiply);
        cd.Invoke(2, 5);

        //invoke all methods using same object
        cd = divide;
        cd(10,5);
        cd = add;
        cd(10, 5);
        cd = subtract;
        cd(10, 5);
    }
}