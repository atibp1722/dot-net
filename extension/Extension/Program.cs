using Extension;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var text = new List<string>
        {
            "fine",
            "quality",
            "adequete",
            "accepable",
            "fair",
            "satisfactory",
            "exemplary",
            "superb",
            "excellent",
            "positive",
            "wonderful",
            "reasonable",
            "logical",
            "reliable",
            "moral",
            "worthy"
        };
        Console.WriteLine("The work done is very {0}.",text.GetRandomItem());
    }

    //shift to another class
    //private static string GetRandomItem(List<string> list) 
    //{
    //    var random = new Random();
    //    return list[random.Next(0,list.Count)];
    //}
}