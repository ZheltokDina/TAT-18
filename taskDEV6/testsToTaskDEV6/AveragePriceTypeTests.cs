using Microsoft.VisualStudio.TestTools.UnitTesting;
using taskDEV6;
using System.Collections.Generic;

namespace UnitTestProject1
{
  [TestClass]
  public class AveragePriceTypeTests
  {
    [TestMethod]
    public void CheckForAveragePriceForTheDifferentTypesOfProducts()
    {
      AveragePriceTypeStrategy averagePriceType = new AveragePriceTypeStrategy();
      List<Product> products = new List<Product>();
      products.Add(new Product("apple", "var", 3, 8));
      products.Add(new Product("banana", "var", 3, 4));
      string type = string.Empty;
      Assert.AreEqual(averagePriceType.Do(products, "banana"), 4);
    }
    [TestMethod]
    public void CheckForAveragePriceForTheSameTypesOfProducts()
    {
      AveragePriceTypeStrategy averagePriceType = new AveragePriceTypeStrategy();
      List<Product> products = new List<Product>();
      products.Add(new Product("apple", "var", 3, 8));
      products.Add(new Product("apple", "var", 3, 4));
      string type = string.Empty;
      Assert.AreEqual(averagePriceType.Do(products, "apple"), 6);
    }
  }
}