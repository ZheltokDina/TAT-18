using System.Collections.Generic;

namespace taskDEV6
{
  /// <summary>
  /// This class considers number of product types
  /// </summary>
  public class CountTypesStrategy : IStrategy
  {
    /// <summary>
    /// This method considers number of product types
    /// </summary>
    public double Do(List<Product> products, string type)
    {
      List<string> types = new List<string>();
      foreach (var product in products)
      {
        if (!(types.Contains(product.Type)))
        {
          types.Add(product.Type);
        }
      }
      return types.Count;
    }
  }
}