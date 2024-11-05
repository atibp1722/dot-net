using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> name = new List<string>();
        name.Add("Ram");
        name.Add("Geeta");

        List<string> new_name = new List<string>();
        new_name.Add("Nita");
        new_name.Add("Indra");

        name.AddRange(new_name);

        for (int i = 0; i < name.Count; i++) 
        {
            var item= name[i];
            Console.Write(item+" ");
        }
        Console.WriteLine();

        foreach (var i in name) 
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();

        List<string> text = new List<string>
        {
            "java",
            "php",
            ".net",
            "c++"
        };
        text.Add("js");
        text.Insert(1, "python");
        text.InsertRange(2,new_name);

        foreach (var i in text)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine(text.Contains("java"));

        text.RemoveRange(2,3);

        foreach (var i in text)
        {
            Console.Write(i + " ");
        }

    }
}