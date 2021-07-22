using System.Collections.Generic;
using System.Linq;

namespace HaiThere.Utilities
{
  public static class EnumerableExtensions
  {

    public static IEnumerable<T> Append<T>(this IEnumerable<T> source, params T[] tail)
    {
      return source.Concat(tail);
    }
  }
}
