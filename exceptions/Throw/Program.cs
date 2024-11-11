using System;

class Program
{
    static void Main(string[] args)
    {
        //user defined catch statement
        try 
        {
            int a = 1;
            int b = 0;
            int c = a / b;
            Console.WriteLine("Result: {0}",c);
        } 
        catch(DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }

        //user defined throw statement
        Console.WriteLine("Enter age:");
        var age=int.Parse(Console.ReadLine());

        if (age >= 21)
        {
            Console.WriteLine("eligible to drink");
        }
        else 
        {
            throw new Exception("ineligible to drink");
        }

        //user defined throw and catch
        Console.WriteLine("Enter age:");
        var ag = int.Parse(Console.ReadLine());

        try
        {
            if (age >= 18)
            {
                Console.WriteLine("eligible to vote");
            }
            else
            {
                throw new Exception("cannot vote");
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        int balance = 1000;
        int withdraw = 1100;

        if (balance < withdraw)
        {
            throw new Exception("balance not enough");
        }
        else 
        {
            balance = balance - withdraw;
            Console.WriteLine("new balance {0}", balance);
        }
    }
}