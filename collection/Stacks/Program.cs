using System;
using System.Collections;

class Program
{
    static void Main(string[] args) 
    {
        Stack stack = new Stack();
        stack.Push(1);
        stack.Push("hi");
        stack.Push(2.5);
        stack.Push('a');
        stack.Push(-0.25);
        stack.Push(1);
        stack.Push(null);

        Console.WriteLine(stack.Count);
        Console.WriteLine(stack.Contains(1));

        foreach (var item in stack) 
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();

        string a = stack.Peek().ToString();
        Console.WriteLine(a);

        stack.Pop();
        stack.Pop();
        stack.Pop();

        foreach (var item in stack)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine(stack.Count);

        Console.WriteLine(stack.Contains(1));
    }
}