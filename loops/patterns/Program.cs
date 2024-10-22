using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("number pattern");
        Console.WriteLine("--------------");

        for (int i = 1; i <= 5; i++)
        {
            for (int j=1; j <= 5; j++)
            {
                Console.Write(j+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write(i*j+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write(i + j + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");

        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");

        Console.WriteLine("char pattern");
        Console.WriteLine("------------");

        char chr = 'a';
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(chr+ " ");
                chr++;
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");

        char chr1 = 'A';
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(chr1 + " ");
                chr1++;
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 5; j >= i; j--)
            {
                Console.Write(" ");
            }
            for(int k=1; k<=i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 5; j >= i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*"+" ");
            }
            Console.WriteLine();
        }
    }
}