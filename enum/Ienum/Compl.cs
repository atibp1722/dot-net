using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienum
{
    public static class Compl
    {
        public static IEnumerable<T> Take<T>(IEnumerable<T> src, int x) 
        {
            int i = 0;
            foreach (var item in src)
            {
                yield return item;

                if (++i == x) 
                {
                    yield break;
                }
            }
        }
    }
}
