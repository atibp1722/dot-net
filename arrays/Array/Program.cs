using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("simple array");
        Console.WriteLine("------------");

        int[] num = new int[3];
        num[0] = 1;
        num[1] = 2;
        num[2] = 3;
        for (int i = 0; i < num.Length; i++) 
        {
            Console.WriteLine(num[i]);
        }
    }
}