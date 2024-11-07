using System;
using System.Threading;

class Program
{

    public static void test_function()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Current value func #0: {0}",i);
        }
    }

    public static void test_function1()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Current value func #1: {0}", i);
        }
    }

    public static void test_function2()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Current value func #2: {0}", i);
        }
    }

    static void Main(string[] args)
    {
        Thread t1 = new Thread(test_function);
        Thread t2 = new Thread(test_function1);
        Thread t3 = new Thread(test_function2);
        
        t1.Start();
        t2.Start();
        t3.Start();

        Console.WriteLine();
        //single thread
        Thread thr = Thread.CurrentThread;
        thr.Name = "Root thread";
        Console.WriteLine(Thread.CurrentThread.Name);
    }
}