using System;
using System.Collections.Generic;

namespace taskDEV6
{
  /// <summary>
  /// This class is used for outputting information about products
  /// </summary>
  public class OutputerInformationAboutProduct
  {
    public void DisplayInformation(List<Product> products)
    {
      foreach (Product product in products)
      {
        Console.WriteLine(product.ReturnData());
      }
    }
  }
}