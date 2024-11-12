using System;
using System.IO;

class Program 
{
    static void Main(string[] args)
    {
        string path = @"C:\\Users\\Admin\\Desktop\\test\\text.txt";

        using FileStream fs = new(path,FileMode.Append,FileAccess.Write);
        {
            using StreamWriter sw = new StreamWriter(fs);
            {
                sw.WriteLine("stream writer");
                sw.WriteLine("file handling");

                int[] num = { 0, 1, 2, 3 };
                foreach (int i in num)
                {
                    sw.Write(i+" ");
                }
            }            
        }
    }
}