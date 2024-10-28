using System;

namespace AccessModifiers
{

    public class Tester: Test
    {
        public void access_tester()
        {
            //private variable not accessible
            //Console.WriteLine(private_var);

            Console.WriteLine(public_var);
            Console.WriteLine(protected_var);
            Console.WriteLine(internal_var);
            Console.WriteLine(protected_internal_var);
        }
    }

    public class Tester1
    {
        public void access_tester1()
        {
            Test tst1 = new Test();

            //cannot access private and protected
            //Console.WriteLine(tst.private_var);
            //Console.WriteLine(tst.protected_var);

            Console.WriteLine(tst1.public_var);
            Console.WriteLine(tst1.internal_var);
            Console.WriteLine(tst1.protected_internal_var);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Tester ttr = new Tester();
            ttr.access_tester();

            Tester1 ttr1 = new Tester1();
            ttr1.access_tester1();
        }
    }
}
