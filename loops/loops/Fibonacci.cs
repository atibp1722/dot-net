using System;

namespace loops
{
    internal class Loops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("swap/fibo sequence");
            Console.WriteLine("------------------");

            Console.WriteLine("Enter number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inital A: " + a+" Inital B: "+b);

            int temp = 0;

            temp = a;
            a = b;
            b = temp;

            /*Swap w/o using third variable
            a = a + b;
            b = a - b;
            a = a - b;
            */

            Console.WriteLine("Swap A: " + a + " Swap B: " + b);
            Console.WriteLine("");

            Console.WriteLine("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int n1 = 1;
            int n2 = 1;
            int n3 = 0;
            Console.WriteLine(n1);
            Console.WriteLine(n2);

            for (int i=1; i <= num; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
