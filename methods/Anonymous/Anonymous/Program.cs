using System;

public delegate void test_delegate(int num);

class Program
{
    public static void test_method(test_delegate tst_del, int age)
    {
        age += 50;
        //Console.WriteLine("Age: {0}", age);
        tst_del.Invoke(age);
    }

    static void Main(string[] args)
    {
        //normal call with delegate
        //test_delegate td = new test_delegate(Program.test_method);
        //td.Invoke(18);

        //anonymous method call
        test_delegate td = delegate (int age) 
        {
            age += 50;
            Console.WriteLine("Age: {0}",age);
        };
        td(10);

        //anonymous method as parameter
        Program.test_method(delegate (int new_age) 
        {
            new_age += 50;
            Console.WriteLine("New age: {0}",new_age);
        },15);
    }
}