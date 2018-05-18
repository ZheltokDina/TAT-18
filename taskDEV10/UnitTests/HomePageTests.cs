using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using taskDEV10.Pages;

namespace UnitTests
{
  [TestClass]
  public class HomePageTests
  {
    IWebDriver driver;

    [TestInitialize]    
    public void SetUp()
    {
      driver = new ChromeDriver();
      driver.Navigate().GoToUrl("https://av.by");
      driver.Manage().Window.Maximize(); 
    }
  [TestMethod]
    public void CheckForThePresenceOfThisMark()
    {
      HomePage home = new HomePage(driver, "Volvo");
      Assert.IsTrue(home.CheckForThePresenceOfThisMark());
    }
    [TestMethod]
    [ExpectedException(typeof(NotFoundException))]
    public void CheckForEstablisheBadMark()
    {
      HomePage home = new HomePage(driver, "mmm");
      home.NavigateToMarkPage();
    }
  }
}
