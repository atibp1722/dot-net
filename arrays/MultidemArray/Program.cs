using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("multi dimensional array");
        Console.WriteLine("-----------------------");

        int[,] test = new int[2, 3];
        test[0, 0] = 1;
        test[0, 1] = 2;
        test[0, 2] = 3;
        test[1, 0] = 4;
        test[1, 1] = 5;
        test[1, 2] = 6;

        for(int i = 0; i <= 1; i++)
        {
            for (int j=0; j <= 2; j++)
            {
                Console.Write(test[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        int[,] n1= new int[2, 2] { { 4, 5 }, { 1, 2 } };
        int[,] n2= new int[2, 2] { { 1, 3 }, { 2, 3 } };
        int[,] result = new int[2, 2];

        for (int i = 0; i <= 1; i++)
        {
            for (int j = 0; j <= 1; j++)
            {
                result[i, j] = n1[i, j] + n2[i, j];
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (int i = 0; i <= 1; i++)
        {
            for (int j = 0; j <= 1; j++)
            {
                result[i, j] = n1[i, j] * n2[i, j];
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        int[][] nums = new int[4][];
        nums[0]=new int[2] {0,1 };
        nums[1] = new int[3] { 2, 3, 4 };
        nums[2] = new int[4] { 5, 6, 7, 8 };
        nums[3] = new int[2] { 9, 10};

        for(int a=0; a<=nums.Length-1;a++)
        {
            for (int b = 0; b < nums[a].Length - 1; b++)
            {
                Console.Write(nums[a][b] + " ");
            }
            Console.WriteLine();
        }
        
    }
}