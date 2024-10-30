using System;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

class Program
{
    const string value = "hello";
    const string value1 = $"{value}, world";

    static void Main(string[] args)
    {
        string text = "dotnet";
        Console.WriteLine("Placeholder is {0} ",text);
        Console.WriteLine("Concatination is "+text);
        Console.WriteLine($"Interpolation is {text}");
        Console.WriteLine(value1);

        Console.WriteLine();
        Console.WriteLine("regular expression");
        Console.WriteLine("------------------");

        String test = "f";
        string pattern = @"^[a-e]$";
        bool isMatch = Regex.IsMatch(test,pattern);
        Console.WriteLine(isMatch);

        String test1 = "axe";
        string pattern1 = @"^[a-e]{3}$";
        bool isMatch1 = Regex.IsMatch(test1, pattern1);
        Console.WriteLine(isMatch1);

        String test2 = "d";
        string pattern2 = @"^[a-e]{1,4}$";
        bool isMatch2 = Regex.IsMatch(test2, pattern2);
        Console.WriteLine(isMatch2);

        String num = "5";
        string pattern3 = @"^[0-9]{1,3}$";
        bool isMatch3 = Regex.IsMatch(num, pattern3);
        Console.WriteLine(isMatch3);

        String num1 = "5";
        string pattern4 = @"^\d$";
        bool isMatch4 = Regex.IsMatch(num1, pattern4);
        Console.WriteLine(isMatch4);

        String test3 = "z";
        string pattern5 = @"^\d$";
        bool isMatch5 = Regex.IsMatch(test3, pattern5);
        Console.WriteLine(isMatch5);

        String test4 = ".edu";
        string pattern6 = @"^(.edu|.mil)$";
        bool isMatch6 = Regex.IsMatch(test4, pattern6);
        Console.WriteLine(isMatch6);

        String test5 = "Hello, I like playing football and watching football";
        string pattern7 = @"football";
        Console.WriteLine("Orginal: {0}",test5);
        string replace_word = "cricket";
        string new_phrase = Regex.Replace(test5, pattern7, replace_word);
        Console.WriteLine("Changed: {0}",new_phrase);
    }
}