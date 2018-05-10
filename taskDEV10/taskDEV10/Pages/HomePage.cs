using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace taskDEV10.Pages
{
  class HomePage
  {
    private IWebDriver driver;
    private string mark;
    HomePageLocators locators = new HomePageLocators();
    public HomePage(IWebDriver driver, string mark)
    {
      this.driver = driver;
      this.mark = mark;
    }
    public bool CheckForThePresenceOfThisMark()
    {
      WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
      driver.FindElement(By.XPath(locators.showAllMark)).Click();
      bool flag = false;
      foreach (IWebElement oneMark in waiter.Until(driver => driver.FindElements(By.XPath(locators.mark))))
      {
       if(mark == oneMark.FindElement(By.TagName("span")).Text)
        {
          flag = true;
          break;
        }
      }
      return flag;
    }
    public void EstablishMark()
    {
      WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
      driver.FindElement(By.XPath(locators.CreateLocatorForMark(mark))).Click();
    }
  }
}