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

        var cmp = new Composition<int> {num1,num2,num3,num4 };

        //int evenCnt = 0;

        //foreach (var num in cmp) 
        //{
        //    if (isEven(num)) 
        //    {
        //        evenCnt++;
        //    }
        //}

        //int evenCnt = cmp.Count(x => isEven(x));
    }
}