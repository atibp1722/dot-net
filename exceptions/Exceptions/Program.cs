using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("exception handling");
        Console.WriteLine("------------------");

        Console.WriteLine("Enter number:");
        int n1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number:");
        int n2=Convert.ToInt32(Console.ReadLine());

        try
        {
            int result = n1 / n2;
            Console.WriteLine("Result:" + result);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Divide by zero not possible");
            Console.WriteLine(e.Message);
        }
        Console.WriteLine();

        int[] num = new int[3];

        try
        {
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            num[3] = 40;

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("Array range exceeded");
        }
        Console.WriteLine();

        try
        {
            string text = null;
            Console.WriteLine("Length:" + text.Length);
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Null cannot have length");
        }
        Console.WriteLine();

        Console.WriteLine("Enter something:");
        string x=Console.ReadLine();

        try
        {
            int x1 = int.Parse(x);
            Console.WriteLine("Number:" + x1);
        }
        catch (FormatException) 
        {
            Console.WriteLine("String format not supported");
        }
        Console.WriteLine();

    }
}