using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();
        queue.Enqueue(10);
        queue.Enqueue(2.5);
        queue.Enqueue("c#");
        queue.Enqueue('b');
        queue.Enqueue(-1.5);

        Console.WriteLine("Count: "+queue.Count);

        foreach (var item in queue)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();


        string a = queue.Peek().ToString();
        Console.WriteLine("Peek: "+a);

        //queue.Dequeue();
        //queue.Dequeue();
        //queue.Dequeue();

        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }

        Console.WriteLine("Count: " + queue.Count);
    }
}