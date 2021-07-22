using System;

namespace ViewTo.Objects
{

  public interface IComponentReport
  {

    public event Action<string> Report;
  }
}
