using System.Collections.Generic;

namespace taskDEV6
{
  /// <summary>
  /// This class considers the average price product for one type
  /// </summary>
  public class AveragePriceTypeStrategy : IStrategy
  {
    /// <summary>
    /// This method considers the average price product for one type
    /// </summary>
    public double Do(List<Product> products, string typeOfProduct)
    {
      double generalPriceType = 0.0;
      int numberOfType = 0;
      foreach (var product in products)
      {
        if (typeOfProduct.Equals(product.Type))
        {
          generalPriceType += product.Price;
          numberOfType++;
        }
      }
      double averagePriceType = generalPriceType / numberOfType;
      return averagePriceType;
    }
  }
}