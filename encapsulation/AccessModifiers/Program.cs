using System;

public class Test
{
    private string private_var = "private";
    public string public_var = "public";
    protected string protected_var = "protected";
    internal string internal_var = "internal";
    protected internal string protected_internal_var = "protected internal";

    public void access_test()
    {
        Console.WriteLine(private_var);
        Console.WriteLine(public_var);
        Console.WriteLine(protected_var);
        Console.WriteLine(internal_var);
        Console.WriteLine(protected_internal_var);
    }
}

public class Test1: Test 
{
    public void access_test1()
    {
        //private variable not accessible
        //Console.WriteLine(private_var);

        Console.WriteLine(public_var);
        Console.WriteLine(protected_var);
        Console.WriteLine(internal_var);
        Console.WriteLine(protected_internal_var);
    }
}

public class Test2
{
    public void access_test2()
    {
        Test tst = new Test();

        //cannot access private and protected
        //Console.WriteLine(tst.private_var);
        //Console.WriteLine(tst.protected_var);

        Console.WriteLine(tst.public_var);
        Console.WriteLine(tst.internal_var);
        Console.WriteLine(tst.protected_internal_var);
    }
}

class Program
{
    static void Main (string[] args)
    {
        Test test= new Test();
        test.access_test();

        Console.WriteLine();

        Test1 test1 = new Test1();
        test1.access_test1 ();

        Console.WriteLine();

        Test2 test2 = new Test2();
        test2.access_test2();
    }
}