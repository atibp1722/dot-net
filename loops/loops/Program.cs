using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("even/odd number sum");
        Console.WriteLine("-------------------");

        Console.WriteLine("Enter low bound: ");
        int low = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter upper bound: ");
        int up = Convert.ToInt32(Console.ReadLine());

        int sum_even = 0;
        int sum_odd = 0;

        for (int i = low; i <= up; i++)
        {
            if (i%2== 0)
            {
                sum_even+=i;
            }
            else if (i%2== 1)
            {
                sum_odd += i;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        Console.WriteLine("even number sum: "+sum_even);
        Console.WriteLine("odd number sum: " + sum_odd);
    }
}