using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Hashtable htbl = new Hashtable();
        htbl.Add("roll",12);
        htbl.Add("name", "Gaurav KC");
        htbl.Add("course","CSE");
        htbl.Add("year", 2024);
        htbl.Add("fee",175000);
        htbl.Add("scholarship", false);
        htbl.Add("grade", 'A');
        htbl.Remove("grade");

        Console.WriteLine(htbl["course"]);
        Console.WriteLine(htbl.Count);
        Console.WriteLine(htbl.Contains("grade"));
        Console.WriteLine(htbl.ContainsValue(true));

        foreach(object key in htbl.Keys)
        {
            Console.Write(key+" ");
        }
        Console.WriteLine();

        foreach (object value in htbl.Values)
        {
            Console.Write(value+" ");
        }
        Console.WriteLine();

        Console.WriteLine("roll".GetHashCode());

        foreach (object key in htbl.Keys)
        {
            Console.Write(key.GetHashCode() + " ");
        }
        Console.WriteLine();
    }
}