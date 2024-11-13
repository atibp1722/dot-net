using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtnDemo
{
    public static class NumClass
    {
        public static bool isEven(this int num)
        {
            return (num % 2) == 0;
        }
    }
}
