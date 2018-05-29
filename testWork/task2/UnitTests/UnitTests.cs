using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task2;

namespace UnitTests
{
  [TestClass]
  public class UnitTests
  {
    [TestMethod]
    public void CheckForValidInputData()
    {
      Rectangle rectangle = new Rectangle("2", "2");
      Assert.AreEqual(4, rectangle.CountTheRectangleSquare());
    }
    [TestMethod]
    public void CheckForMinValidInputData()
    {
      Rectangle rectangle = new Rectangle("0,01", "0,02");
      Assert.IsTrue(rectangle.CountTheRectangleSquare() == 0.0002);
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CheckForUnvalidData()
    {
      Rectangle rectangle = new Rectangle("2", "0");
    }
  }
}
