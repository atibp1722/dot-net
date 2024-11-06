using Dictionary;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict.Add("Victus","budget laptops from HP");
        dict.Add("Omen", "business laptops from HP");
        dict.Add("Probook", "enterprise laptops from ASUS");
        dict.Add("Katana", "high-end gaming laptops from MSI");
        dict.Add("Nitro", "medium gaming laptops from ACER");

        Dictionary<int, string> dict1 = new Dictionary<int, string>();
        dict1.Add(1, "Ram Karki");
        dict1.Add(2, "Gita Sharma");
        dict1.Add(3, "Hari Shakya");
        dict1.Add(4, null);

        Console.WriteLine(dict.Count);
        Console.WriteLine(dict1.Count);
        Console.WriteLine();

        //Console.WriteLine(dict["katana"]);

        foreach (string key in dict.Keys)
        {
            Console.WriteLine(key);
        }
        Console.WriteLine();

        foreach (string value in dict.Values)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine();

        foreach (KeyValuePair<string, string> item in dict)
        {
            Console.WriteLine("Key: " + item.Key + ", Value: " + item.Value);
        }
        Console.WriteLine();

        foreach (KeyValuePair<int, string> item in dict1)
        {
            Console.WriteLine("ID: " + item.Key + ", Name: " + item.Value);
        }
        Console.WriteLine();

        dict1.Remove(2);

        foreach (KeyValuePair<int, string> item in dict1)
        {
            Console.WriteLine("ID: " + item.Key + ", Name: " + item.Value);
        }

        Console.WriteLine(dict1.ContainsKey(1));
        Console.WriteLine(dict1.ContainsValue("Ram Karki"));

        string dummy;

        if (dict1.TryGetValue(2, out dummy))
        {
            Console.WriteLine(dummy);
        }
        else 
        {
            Console.WriteLine("No such key exists");
        }
        Console.WriteLine();

        Person prsn = new Person()
        {
            id = 2,
            name = "Ramesh Mahat",
            address = "Kathmandu",
            age = 28
        };
        Person prsn1 = new Person()
        {
            id = 7,
            name = "Deepa GC",
            address = "Dharan",
            age = 19
        };
        Person prsn2 = new Person()
        {
            id = 1,
            name = "Nilesh Bista",
            address = "Patan",
            age = 31
        };

        Dictionary<int, Person> personDict = new Dictionary<int, Person>();
        personDict.Add(prsn.id, prsn);
        personDict.Add(prsn1.id, prsn1);
        personDict.Add(prsn2.id, prsn2);

        Console.WriteLine(personDict.Count(person => person.Value.age>18));
        Console.WriteLine(personDict.Count(person => person.Value.name.StartsWith("A")));

    }
}