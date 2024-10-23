using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("min max in array");
        Console.WriteLine("----------------");

        Console.WriteLine("Enter array size:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] num = new int[size];

        int min = 0;
        int max = 0;

        for (int i = 0; i < size - 1; i++)
        {
            Console.WriteLine("Enter array element:");
            num[i] = Convert.ToInt32(Console.ReadLine());
        }

        min = num[0];
        max = num[0];

        for (int i = 0; i < size - 1; i++)
        {
            if (min > num[i])
            {
                min = num[i];
            }
            if (max < num[i])
            {
                max = num[i];
            }
        }
        Console.WriteLine("Min element:" + min);
        Console.WriteLine("Max element:" + max);
    }
}