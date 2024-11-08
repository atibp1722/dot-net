using System;

public delegate double test_delegate(double num);
class Program
{
    static void Main(string[] args)
    {
        //regular expression
        //test_delegate td = delegate(double weight) 
        //{
        //    weight *= 2.2;
        //    Console.WriteLine("Weight {0} lbs",weight);
        //};
        //td.Invoke(64.7);

        //statement lambda expression
        test_delegate td = (weight) =>
        {
            weight *= 2.2;
            Console.WriteLine("Weight {0:0.#} lbs", weight);
        };
        td.Invoke(65.5);

        //expression lambda
        test_delegate td1 = (weight) => weight * 2.2 * 16;
        Console.WriteLine("Weight {0:0.#} oz",td1.Invoke(65));

    }
}