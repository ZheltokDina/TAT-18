using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using taskDEV6;

namespace testsToTaskDEV6
{
  [TestClass]
  public class CheckForInvalidValue
  {
    [ExpectedException(typeof(FormatException))]
    [TestMethod]
    public void CheckForInvalidProductType()
    {
      new Product("66", "vas", 6, 7);
    }
    [ExpectedException(typeof(FormatException))]
    [TestMethod]
    public void CheckForInvalidProductName()
    {
      new Product("apple", string.Empty, 6, 7);
    }
    [ExpectedException(typeof(FormatException))]
    [TestMethod]
    public void CheckForInvalidProductCount()
    {
      new Product("apple", "vas", 0, 7);
    }
    [ExpectedException(typeof(FormatException))]
    [TestMethod]
    public void CheckForInvalidProductPrice()
    {
      new Product("apple", "vas", 20, -2);
    }
  }
}