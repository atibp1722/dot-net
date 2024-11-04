using System;

class Test<X>
{
    X a;
    
    //public Test(X a)
    //{
    //    this.a = a;
    //}

    //public X getA()
    //{
    //    return this.a;
    //}

    public X getsA 
    {
        set 
        {
            this.a=value;
        }
        get 
        {
            return this.a;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Test<int> test = new Test<int>(15);
        //Console.WriteLine(test.getA());

        //Test<string> test1 = new Test<string>("Ram");
        //Console.WriteLine(test1.getA());

        //Test<int> test2 = new Test<int>();
        //Console.WriteLine(test2.getA());

        Test<char> test3 = new Test<char>();
        test3.getsA = 'X';
        Console.WriteLine(test3.getsA);

        Test<double> test4 = new Test<double>();
        test4.getsA = 3.75;
        Console.WriteLine(test4.getsA);
    }
}