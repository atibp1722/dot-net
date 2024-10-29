using System;
using System.Text;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        String s1 = "dotnet";

        Stopwatch sw = new Stopwatch(); 
        sw.Start();

        for (int i = 0; i <= 10000; i++)
        {
            s1 = s1+i;
        }
        sw.Stop();  

        StringBuilder sb = new StringBuilder("c#");

        Stopwatch sw1 = new Stopwatch();  
        sw1.Start();
        for (int i = 0; i <= 10000; i++)
        {
            sb.Append(i);
        }
        sw1.Stop();

        Console.WriteLine("String execution time {0}ms", sw.ElapsedMilliseconds);
        Console.WriteLine("StringBuilder execution time {0}ms", sw1.ElapsedMilliseconds);

        StringBuilder sb1 = new StringBuilder("hello, world this is dot net language using viual studio", 50);
        Console.WriteLine(sb1.Length);

        StringBuilder sb2 = new StringBuilder("Test ");
        sb2.Append("program");
        Console.WriteLine(sb2);

        StringBuilder sb3 = new StringBuilder("String ");
        sb3.AppendLine("builder");
        sb3.Append("test");
        Console.WriteLine(sb3);

        StringBuilder sb4 = new StringBuilder();
        sb4.AppendFormat("{0:C}",10);
        sb4.AppendFormat("--{0:N}--", 10);
        sb4.AppendFormat("{0:X}", 10);
        Console.WriteLine(sb4);

        StringBuilder sb5 = new StringBuilder("microscopic");
        sb5.Insert(3, "x");
        sb5.Replace("i", "z");
        //sb5.Clear();
        sb5.Remove(3, 7);
        Console.WriteLine(sb5);

        StringBuilder sb6 = new StringBuilder("program");
        Console.WriteLine(sb6.GetType());
        string str = sb6.ToString();
        Console.WriteLine(str.GetType());
    }
}