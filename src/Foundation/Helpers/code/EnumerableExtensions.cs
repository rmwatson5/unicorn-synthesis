using System.Collections.Generic;
using System.Linq;

namespace Sitecore.Foundation.Helpers
{
    public static class EnumerableExtensions
    {
        public static bool HasAny<T>(this IEnumerable<T> items)
        {
            return items != null && items.Any();
        }
    }
}
