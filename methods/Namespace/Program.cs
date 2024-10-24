using System;
/* using aliasing to resolve when class have same name */
using ss1 = sample.sub_sample;
using ss2 = sample.sub_sample_s;

class Program
{
    static void Main(string[] args)
    {
        //sample.sub_sample.Test.display();
        //sample.sub_sample_s.Test.display();

        //direct call through 'using' and aliasing
        ss1.Test.display();
        ss2.Test.display();

    }
}

namespace sample
{
    namespace sub_sample
    {
        class Test
        {
            public static void display()
            {
                Console.WriteLine("This is display method for 'Test' class");
            }
        }
    }
}

namespace sample
{
    namespace sub_sample_s
    {
        class Test
        {
            public static void display()
            {
                Console.WriteLine("This is display method for 'sub_sample_s' namespace");
            }
        }
    }
}