using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace taskDEV10.Pages
{
  /// <summary>
  /// This class works with the home page
  /// </summary>
  public class HomePage
  {
    private IWebDriver driver;
    private string mark;
    Locators locators = new Locators();
    IWebElement element;
    WebDriverWait waiter;

    public HomePage(IWebDriver driver, string mark)
    {
      this.driver = driver;
      this.mark = mark;
    }

    /// <summary>
    /// This method verifies the availability of this mark on the site
    /// </summary>
    public bool CheckForThePresenceOfThisMark()
    {
      waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
      element = waiter.Until(driver => driver.FindElement(By.XPath(locators.ShowAllMark)));
      element.Click();
      bool flag = false;
      foreach (IWebElement oneMark in driver.FindElements(By.XPath(locators.Mark)))
      {
        if (mark == oneMark.FindElement(By.TagName("span")).Text)
        {
          flag = true;
          break;
        }
      }
      return flag;
    }
    /// <summary>
    /// This method establishes the mark, so it goes to the mark page
    /// </summary>
    public MarkPage NavigateToMarkPage()
    {
      if (!CheckForThePresenceOfThisMark())
      {
        throw new NotFoundException("This mark does not exist on the site");
      }
      waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
      element = waiter.Until(driver => driver.FindElement(By.XPath(locators.CreateLocatorForMark(mark))));
      element.Click();
      return new MarkPage( driver);
    }
    /// <summary>
    /// This method closeы advertising
    /// </summary>
    public void CloseAdvertising()
    {
      element = driver.FindElement(By.XPath(locators.FindAdvertising));
      if(element.Displayed)
      {
        driver.FindElement(By.XPath(locators.CloseAdvertising));
      }
    }

  }
}