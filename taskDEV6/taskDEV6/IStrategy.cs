using System.Collections.Generic;

namespace taskDEV6
{
  public interface IStrategy
  {
    double Do(List<Product> products, string type = "");
  }
}