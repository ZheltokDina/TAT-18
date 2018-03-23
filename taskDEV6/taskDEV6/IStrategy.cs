using System.Collections.Generic;

namespace taskDEV6
{
  public interface IStrategy
  {    
    void Do(List<Product> products, string type = "");
  }
}