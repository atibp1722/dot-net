using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtnDemo
{
    public static class StringClass
    {
        public static string[] Split(this string @this, char separator, int count) 
        {
            if (@this == null) 
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return @this.Split(new[] {separator}, count);
        }

        public static bool IsNullOrEmpty(this string @this) 
        {
            return string.IsNullOrEmpty(@this);
        }
    }
}
