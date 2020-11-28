using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTrader.Models.Helpers
{
    public static class CollectionExtensions
    {
        // Ex: collection.TakeLast(5);
        public static IEnumerable<T> TakeLastOf<T>(this IEnumerable<T> source, int n)
        {
            return source.Skip(Math.Max(0, source.Count() - n));
        }
    }
}
