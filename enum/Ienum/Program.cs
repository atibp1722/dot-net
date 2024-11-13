using Ienum;
using System;
using System.Linq;

class Program
{
    public static bool isEven(int num)
    {
        return num % 2 == 0;
    }
    static void Main(string[] args)
    {
        var num1 = new List<int> {1,2,3,4,5};
        var num2 = new List<int> {5,6,7,8,9};
        var num3 = new HashSet<int> {3,6,9,12,15};
        var num4 = new [] {5,10,15,20,25};

        //var cmp = new Composition<int>(new IEnumerable<int>[] { num1,num2,num3,num4 });

        //var cmp = new Composition<int> {num1,num2,num3,num4 };

        //int evenCnt = 0;

        //foreach (var num in cmp)
        //{
        //    if (isEven(num))
        //    {
        //        evenCnt++;
        //    }
        //}
        ////int evenCnt = cmp.Count(x => isEven(x));

        //IEnumerable<int> test = Compl.Take(num1,2);
        //foreach(var i in test) 
        //{

        //}

        //var cmp1 = Composition.Create(new IEnumerable<int>[]{ num1, num2, num3, num4 });

        //int evenCnt1 = 0;

        //foreach (var num in cmp1)
        //{
        //    if (isEven(num))
        //    {
        //        evenCnt1++;
        //    }
        //}
        //int evenCnt1 = cmp1.Count(x => isEven(x));

        int count = Composition.Create(num1,num2,num3,num4).Count(x => isEven(x));

        HashSet<int> hash = Composition.Create(num1, num2, num3, num4).TypeTo<HashSet<int>>();
    }
}