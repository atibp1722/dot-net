using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("vowel consonant count");
        Console.WriteLine("---------------------");

        Console.WriteLine("Enter string:");
        string text = Console.ReadLine();
        char[] chr = text.ToCharArray();

        int cnt_vwl = 0;
        int cnt_const = 0;

        /* Manaual method - Repeat character count
        for (int i = 0; i <= chr.Length - 1; i++)
        {
            if (chr[i] == 'a'|| chr[i] == 'e'||chr[i] == 'i'||chr[i] == 'o'|| chr[i] == 'u')
            {
                cnt_vwl += 1;
            }
            else
            {
                cnt_const += 1;
            }
        }
        */

        for (int i = 0; i <= chr.Length - 1; i++)
        {
            for (int j = i + 1; j <= chr.Length - 1; j++)
            {
                if (chr[i] == chr[j])
                {
                    chr[j] = ' ';
                }
            }
            if (chr[i] != ' ')
            { 
                if (chr[i] == 'a' || chr[i] == 'e' || chr[i] == 'i' || chr[i] == 'o' || chr[i] == 'u')
                {
                    cnt_vwl += 1;
                }
                else
                {
                    cnt_const += 1;
                }
            }
        }
        Console.WriteLine("Vowel count: "+cnt_vwl);
        Console.WriteLine("Consonant count: "+cnt_const);
    }
 }
