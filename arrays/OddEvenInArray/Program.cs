using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("odd even in array");
        Console.WriteLine("------------------");

        int even_sum = 0;
        int odd_sum = 0;

        int[] num = new int[5];
        for (int i = 0; i < num.Length; i++) 
        {
            Console.Write("Enter number: ");
            num[i]=int.Parse(Console.ReadLine());

            if (num[i] % 2 == 0)
            {
                even_sum = even_sum + num[i];
            }
            else
            {
                odd_sum = odd_sum + num[i];
            }
        }
        Console.WriteLine("even sum: " + even_sum);
        Console.WriteLine("odd sum: " + odd_sum);
        Console.WriteLine("---------------");

        int evn_cnt = 0;
        int odd_cnt = 0;

        int[] nums = new int[5];
        for(int i=0; i < nums.Length; i++)
        {
            Console.Write("Enter number: ");
            nums[i] = int.Parse(Console.ReadLine());

            if (nums[i] % 2 == 0) 
            {
                evn_cnt += 1;
            }
            else
            {
                odd_cnt += 1;
            }
        }
        Console.WriteLine("even count: " + evn_cnt);
        Console.WriteLine("odd count: " + odd_cnt);
    }
}