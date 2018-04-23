using Microsoft.VisualStudio.TestTools.UnitTesting;
using taskDEV6;
using System.Collections.Generic;

namespace UnitTestProject1
{
  [TestClass]
  public class CountAllTests
  {
    [TestMethod]
    public void CheckForCountAllProduct()
    {
      CountAllStrategy countAll = new CountAllStrategy();
      List<Product> products = new List<Product>();
      products.Add(new Product("apple", "var", 3, 4));
      products.Add(new Product("banana", "var", 3, 4));
      string type = string.Empty;
      Assert.AreEqual(countAll.Do(products, type), 6);
    }
  }
}