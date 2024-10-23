using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("palindrome check");
        Console.WriteLine("----------------");

        Console.WriteLine("Enter string:");
        string text = Console.ReadLine();
        char[] chr = text.ToCharArray();
        string rev_text = null;
        
        for(int i = text.Length-1; i >= 0; i--)
        {
            rev_text = rev_text + chr[i];
        }
        if (text == rev_text)
        {
            Console.WriteLine("Text is palindrome");
        }
        else
        {
            Console.WriteLine("Text is not palindrome");
        }

        string test = "this,is,dot,net,array";
        Console.WriteLine(test);
        char[] ch = test.ToCharArray();

        for (int i = 0; i <= test.Length - 1; i++)
        {
            if (ch[i] == ',') 
            {
                ch[i] = ' ';
            }
            Console.Write(ch[i]);
        }
    }
}