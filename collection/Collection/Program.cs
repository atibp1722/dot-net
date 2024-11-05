using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {

        ArrayList al = new ArrayList();
        Console.WriteLine(al.Capacity);
        al.Add(1);
        al.Add("Ram");
        al.Add('b');
        al.Add(2.5);
        Console.WriteLine(al.Capacity);
        al.Add(-1);
        Console.WriteLine(al.Capacity);

        foreach (object i in al) 
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();

        al.Insert(3, "new#1");
        al.Insert(4, "new#2");

        foreach (object i in al)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        al.RemoveAt(3);
        al.Remove("new#2");

        foreach (object i in al)
        {
            Console.Write(i + " ");
        }

        //int[] num = new int[3] { 1, 2, 3 };
        //for (int i = 0; i < num.Length; i++)
        //{
        //    Console.WriteLine(num[i]);
        //}
        //Console.WriteLine("-----");

        //Array.Resize(ref num, 4);
        //num[3] = 4;

        //for (int i = 0; i < num.Length; i++)
        //{
        //    Console.WriteLine(num[i]);
        //}
    }
}