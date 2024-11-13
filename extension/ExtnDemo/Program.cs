using ExtnDemo;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //5.isEven();

        //string test = null;
        //test.IsNullOrEmpty();

        var greet = new List<string> 
        {
            "hello",
            "namaste",
            "namaskar",
            "nihao",
            "hola",
            "bounjour",
            "guten tag",
            "konichiwa",
            "salve"
        };

        var msg = greet.FirstOr(s => s.Length.isEven(),greet.GetRandomItem);
        Console.WriteLine("Greeting {0}",msg);
    }
}