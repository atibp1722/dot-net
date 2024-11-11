using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int a = 2;
            int b = 0;
            int c = a / b;
            Console.WriteLine("Result {0}", c);

            string text = null;
            Console.WriteLine(text.Length);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (NullReferenceException e) 
        { 
            Console.WriteLine(e.Message); 
        }
        catch (FileNotFoundException e) 
        { 
            Console.WriteLine(e.Message); 
        }
        finally
        {
            Console.WriteLine("finally block reached");
        }
    }
}