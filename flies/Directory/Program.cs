using System;
using System.IO;

class Program 
{
    static void Main(string[] args)
    {
        string path = @"C:\\Users\\Admin\\Desktop\\test_directory";
        //string path1 = @"C:\\Users\\Admin\\Desktop\\test_directory_1";

        DirectoryInfo di = new DirectoryInfo(path);
        di.Create();
        di.CreateSubdirectory("sub_directory");

        //move to shifts all to new and deletes the old directory
        //di.MoveTo(path1);

        //delete empty directory only
        //di.Delete(true);

        Console.WriteLine(di.Name);
        Console.WriteLine(di.FullName);
        Console.WriteLine(di.LastAccessTime);
        Console.WriteLine(di.Parent);
        Console.WriteLine(di.Root);
        Console.WriteLine(di.LastWriteTime);

        DirectoryInfo[] dir_list = di.GetDirectories(path);
        foreach(var i in dir_list) 
        {
            Console.WriteLine(i);
        }

        foreach (var i in dir_list)
        {
            Console.WriteLine(i.GetFiles().Length);
        }

        //Console.WriteLine("directory deleted");
    }
}