using System;
using System.Collections;

namespace HaiThere.Utilities
{

  public static class General
  {
    public static T Empty<T>()
    {
      var t = (T) Activator.CreateInstance(typeof(T));
      return t;
    }

    public static bool Valid(this IList list)
    {
      return list != null && list.Count > 0;
    }

    public static bool Valid(this string value)
    {
      return !string.IsNullOrEmpty(value);
    }
  }
}
