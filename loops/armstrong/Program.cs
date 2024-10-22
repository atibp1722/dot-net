using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("armstrong number");
        Console.WriteLine("----------------");

        Console.WriteLine("Enter number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        int og_num = num;

        int rem = 0;
        int sum = 0;
        int cube = 0;

        while (num > 0)
        {
            rem = num % 10;
            cube = rem * rem * rem;
            sum = sum + cube;
            num = num/10; 
        }
        if (og_num == sum)
        {
            Console.WriteLine(og_num + " is armstrong number");
        }
        else
        {
            Console.WriteLine(og_num + " is not armstrong number");
        }
    }
}