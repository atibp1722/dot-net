using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class Lists
    {
        private static Random _random = new Random();
        public static T GetRandomItem<T>(this List<T> list)
        {
            return list[_random.Next(0, list.Count)];
        }
    }
}
