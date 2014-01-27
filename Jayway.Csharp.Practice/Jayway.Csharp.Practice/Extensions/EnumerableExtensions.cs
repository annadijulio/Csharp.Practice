using System;
using System.Collections.Generic;

namespace Jayway.Csharp.Practice.Extensions
{
    public static class EnumerableExtensions
    {

        public static void ForEach<T>(this IEnumerable<T> self, Action<T> action)
        {
            foreach (var item in self)
            {
                action(item);
            }
        }

     

        public static bool Any2<T>(this IEnumerable<T> self, Func<T, bool> predicate)
        {
            foreach (var item in self)
            {
                if (predicate(item))
                {
                    return true;
                }

            }
            return false;
        } 

        public static IEnumerable<T> Where<T>(this IEnumerable<T> self, Func<T, bool> predicate)
        {
            var result = new List<T>();
            foreach (var item in self)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
