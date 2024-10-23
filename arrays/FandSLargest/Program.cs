using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("first & second largest");
        Console.WriteLine("----------------------");

        int[] num = new int[5] {1,9,4,6,2};
        int f_largest = num[0];
        int s_largest = num[0];
        int f_smallest = num[0];
        int s_smallest= num[0];

        for (int i = 0; i< num.Length; i++) 
        {
            Console.WriteLine("Index "+i+": "+num[i]);
        }

        for (int i=0; i< num.Length - 1; i++)
        {
            if (num[i] > f_largest)
            {
                f_largest= num[i];
            }
        }
        Console.WriteLine("Largest element:"+f_largest);

        for(int j = 0; j< num.Length - 1; j++)
        {
            if(num[j] > s_largest && f_largest != num[j])
            {
                s_largest = num[j];
            }
        }
        Console.WriteLine("2nd largest element:" + s_largest);

        for (int i = 0; i < num.Length - 1; i++)
        {
            if (num[i] < f_smallest)
            {
                f_smallest = num[i];
            }
        }
        Console.WriteLine("Smallest element:" + f_smallest);

        for (int k = 0; k < num.Length; k++)
        {
            if (num[k] < s_smallest && f_smallest != num[k])
            {
                s_smallest = num[k];
            }
        }
        Console.WriteLine("2nd smallest element:" + s_smallest);
    }
}