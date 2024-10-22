using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("digits sum");
        Console.WriteLine("----------");

        int num = 72252;

        int rem = 0;
        int sum = 0;
        
        for (int i= 1; i <=5; i++)
        {
            if(i==1 || i == 5)
            {
                rem = num % 10;
                sum = sum + rem;
            }
            num = num / 10;
        }
        Console.WriteLine(sum);
    }
}