using Serialize;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    static void Main(string[] args)
    {
        Person prs = new Person(10,"Ram Karki");
        string path = "C:\\file\\test.txt";
        FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(fs, prs);
        fs.Close();

        Console.WriteLine("File created");

        FileStream fs1 = new FileStream(path, FileMode.OpenOrCreate);
        BinaryFormatter bf1 = new BinaryFormatter();
        Person prs1 = (Person)bf1.Deserialize(fs1);

        Console.WriteLine("Id: "+prs1.id);
        Console.WriteLine("Name: " + prs1.name);
        fs1.Close();
    }
}