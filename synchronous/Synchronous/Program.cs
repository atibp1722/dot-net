using System;
using System.Threading.Tasks;

class Program
{
    public static async void test_function_1() 
    {
        await Task.Run(() => 
        {
            Console.WriteLine("Function 1 initiated");
            Thread.Sleep(4000);
            Console.WriteLine("Function 1 completed");
        }); 
    }

    public static async void test_function_2()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Function 2 initiated");
            Thread.Sleep(3000);
            Console.WriteLine("Function 2 completed");
        });
    }

    public static async void test_function_3()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Function 3 initiated");
            Thread.Sleep(1500);
            Console.WriteLine("Function 3 completed");
        });
    }

    public static async void test_function_4()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Function 4 initiated");
            Thread.Sleep(5000);
            Console.WriteLine("Function 4 completed");
        });
    }

    static void Main(string[] args)
    {
        test_function_1();
        test_function_2();
        test_function_3();
        test_function_4();
    }
}