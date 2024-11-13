using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtnDemo
{
    public static class IEnumExtn
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> @this)
        {
            return @this==null || !@this.Any();
        }

        public static bool IsEmpty<T>(this IEnumerable<T> @this)
        {
            return !@this.Any();
        }

        public static T FirstOr<T>(this IEnumerable<T> @this, Func<T, bool> pred, Func<T> or)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            T found = @this.FirstOrDefault(pred);
            if (found.Equals(default(T))) 
            {
                found = or();
            }

            return found;
        }
    }
}
