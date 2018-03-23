using Microsoft.VisualStudio.TestTools.UnitTesting;
using taskDEV6;
using System.Collections.Generic;

namespace UnitTestProject1
{
  [TestClass]
  public class AveragePriceTests
  {
    [TestMethod]
    public void CheckForAveragePriceAllProducts()
    {
      AveragePriceStrategy averagePrice = new AveragePriceStrategy();
      List<Product> products = new List<Product>();
      products.Add(new Product("apple", "var", 3, 8));
      products.Add(new Product("banana", "var", 3, 4));
      string type = string.Empty;
      Assert.AreEqual(averagePrice.Do(products, type), 6);
    }
  }
}