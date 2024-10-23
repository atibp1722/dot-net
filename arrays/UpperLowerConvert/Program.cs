using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("upper lower convert");
        Console.WriteLine("-------------------");

        Console.WriteLine("Enter string:");
        string text = Console.ReadLine();
        char[] chr = text.ToCharArray();

        for (int i = 0; i <= chr.Length - 1; i++) 
        {
            int a = Convert.ToInt32(chr[i]);
            if(a>=97 && a<=122)
            {
                a = a - 32;
                Console.Write(Convert.ToChar(a));
            }

            int b = Convert.ToInt32(chr[i]);
            if (b >=65&& b <= 90)
            {
                b = b + 32;
                Console.Write(Convert.ToChar(b));
            }
        }
        Console.WriteLine();
    }
}