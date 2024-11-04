using System;
using System.Data;

class Test
{
    public static void printArray<X>(X[] array) 
    {
        for (int i = 0; i < array.Length; i++) 
        {
            Console.WriteLine(array[i]);
        }
    }

    public static bool checkStatus<Y>(Y a, Y b)
    {
        bool c =a.Equals(b);
        return c;
    }

    public static void showType<Z>(Z c)
    {
        Console.WriteLine(typeof(Z));
    }

}

class Program
{
    static void Main(string[] args)
    {
        int[] num = new int[3];
        num[0] = 10;
        num[1] = 20;
        num[2] = 30;

        string[] text = { "java", "php", "c++" };

        double[] point = { 1.5, 2.5, 3.5 };

        Test.printArray(num);
        Test.printArray(text);
        Test.printArray(point);

        Console.WriteLine(Test.checkStatus(1, 1));
        Console.WriteLine(Test.checkStatus('a', 'A'));
        Console.WriteLine(Test.checkStatus("ram", "ram"));
        Test.showType("a");
    }
}