using System;

interface Test 
{
    void rand_method();
}
interface Test1
{
    void rand_method();
}

class Pogram: Test, Test1
{
    public void Test.rand_method()
    {
        Console.WriteLine("interface method for TEST");
    }

    public void Test1.rand_method()
    {
        Console.WriteLine("interface method called for TEST1");
    }

    static void Main(string[] args)
    {
        Program prg = new Program();
        ((Test)prg).rand_method();
        ((Test1)prg).rand_method();
    }
}