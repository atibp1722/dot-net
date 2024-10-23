using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("min max swap");
        Console.WriteLine("------------");

        int[] num = new int[6] { 7, 4, 1, 0, 5, 2 };

        for (int i = 0; i < num.Length; i++) 
        {
            Console.Write(num[i]+" ");
        }
        Console.WriteLine();

        int min = num[0];
        int max = num[0];
        int min_index = 0;
        int max_index = 0;

        for (int i = 0; i < num.Length - 1; i++) 
        {
            if(num[i] < min)
            {
                min= num[i];
                min_index = i;
            }
            if (num[i] > max)
            {
                max = num[i];
                max_index = i;
            }
        }
        Console.WriteLine("Minimum element: " + min);
        Console.WriteLine("maximum element: " + max);

        num[min_index] = max;
        num[max_index] = min;

        for(int i=0; i < num.Length; i++)
        {
            Console.Write(num[i]+" ");
        }
    }
}