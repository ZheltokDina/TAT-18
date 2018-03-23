using System.Collections.Generic;

namespace taskDEV6
{
  /// <summary>
  /// This class considers the average price of all products
  /// </summary>
  public class AveragePriceStrategy : IStrategy
  {
    /// <summary>
    /// This method considers the average price of all products
    /// </summary>
    public double Do(List<Product> products, string type)
    {
      double generalPrice = 0.0;
      foreach (var product in products)
      {
        generalPrice += product.Price;
      }
      double averagePrice = generalPrice / products.Count;
      return averagePrice;
    }
  }
}