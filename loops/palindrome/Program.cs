using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("palindrome check");
        Console.WriteLine("---------------");

        Console.WriteLine("Enter number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        int og_num = num;

        int rem = 0;
        int rev_num = 0;

        while (num > 0) 
        {
            rem = num % 10;
            rev_num = (rev_num * 10) + rem;
            num = num / 10;
        }
        Console.WriteLine("reversed number " + rev_num);
        if (og_num == rev_num)
        {
            Console.WriteLine(og_num + " is palindrome");
        }
        else
        {
            Console.WriteLine(og_num + " is not palindrome");
        }

        Console.WriteLine("---------------");
        Console.WriteLine("Enter a string: ");
        string txt=Console.ReadLine();
        string og_txt = txt;

        char[] chr = txt.ToCharArray();

        string rev_txt = null;

        for(int i=txt.Length-1;i>=0;i--)
        {
            rev_txt = rev_txt + chr[i];
        }
        Console.WriteLine("reversed string "+rev_txt);
        if(og_txt == rev_txt)
        {
            Console.WriteLine(og_txt+" is palindrome");
        }
        else
        {
            Console.WriteLine(og_txt + " is not palindrome");
        }

    }
}