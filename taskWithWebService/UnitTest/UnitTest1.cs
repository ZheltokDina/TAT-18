using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using taskWithWebService;

namespace UnitTest
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void CheckForCorrectnessOfCounting()
    {
      WebService webServis = new WebService();
      Assert.AreEqual(8, webServis.CountDays(new DateTime(0001, 01, 09)));
    }
    [TestMethod]
    public void CheckDaysWhichPassedSinceToday()
    {
      WebService webServis = new WebService();
      Assert.AreEqual(736834, webServis.CountDays(new DateTime(2018, 05, 21)));
    }
  }
}