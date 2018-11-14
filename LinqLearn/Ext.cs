using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLearn
{
    public static class Ext
    {
        public static int Ext_Count<T>(this IEnumerable<T> items)
        {
            int count = 0;
            foreach (var item in items)
            {
                count += 1;
            }
            return count;
        }
    }
}
