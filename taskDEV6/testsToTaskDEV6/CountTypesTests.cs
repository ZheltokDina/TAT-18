using Microsoft.VisualStudio.TestTools.UnitTesting;
using taskDEV6;
using System.Collections.Generic;

namespace testsToTaskDEV6
{
  [TestClass]
  public class CountTypesTests
  {
    [TestMethod]
    public void CheckForNumberOfTypesForTheDifferentTypesOfProducts()
    {
      CountTypesStrategy countTypes = new CountTypesStrategy();
      List<Product> products = new List<Product>();
      products.Add(new Product("apple", "var", 3, 4));
      products.Add(new Product("banana", "var", 3, 4));
      string type = string.Empty;
      Assert.AreEqual(countTypes.Do(products, type), 2);
    }
    [TestMethod]
    public void CheckForNumberOfTypesForTheSameTypesOfProducts()
    {
      CountTypesStrategy countTypes = new CountTypesStrategy();
      List<Product> products = new List<Product>();
      products.Add(new Product("apple", "var", 3, 4));
      products.Add(new Product("apple", "vas", 3, 4));
      string type = string.Empty;
      Assert.AreEqual(countTypes.Do(products, type), 1);
    }
  }
}