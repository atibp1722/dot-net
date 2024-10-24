using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        int y = 10;
        static_method(y);

        int b = 10;
        static_method(ref b);

        Console.WriteLine(y);
        Console.WriteLine(b);

        int total = 0;
        int product = 0;
        calculator(7,8,out total,out product);
        Console.WriteLine("Total: "+total);
        Console.WriteLine("Product: "+product);

        int[] num = new int[3];
        num[0] = 17;
        num[0] = 11;
        num[0] = 10;
        param_array(num);
    }

    //call by value- point at different location, modifying one does not affect value of another
    public static void static_method(int x)
    {
        x= 1;
    }

    //call by reference- point at same location, modifying one does affect value of another
    public static void static_method(ref int a)
    {
        a = 1;
    }

    //out params- multiple operations from same method
    public static void calculator(int c,int d, out int add, out int multiply)
    {
        add = c + d;
        multiply = c * d;
    }

    //parameter array- array has to be last parameter
    public static void param_array(params int[] num)
    {
        Console.WriteLine("No of elements: "+num.Length);
        foreach (int m in num)
        {
            Console.WriteLine(m);
        }
    }
}