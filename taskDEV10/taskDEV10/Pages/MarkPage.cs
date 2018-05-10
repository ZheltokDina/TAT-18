using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace taskDEV10.Pages
{
  class MarkPage
  {
    private IWebDriver driver;
    MarkPageLocators locators = new MarkPageLocators();
    Dictionary<string, int> modelAndNumberCarOfModel;
    public MarkPage(IWebDriver driver)
    {
      this.driver = driver;
    }
    public Dictionary<string, int> ReadAllModelWithNumberOfCarThisModel()
    {
      modelAndNumberCarOfModel = new Dictionary<string, int>();
      WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
      foreach (IWebElement oneModel in waiter.Until(driver => driver.FindElements(By.XPath(locators.model))))
      {
        modelAndNumberCarOfModel.Add((oneModel.FindElement(By.TagName("span")).Text), int.Parse(oneModel.FindElement(By.TagName("small")).Text));
      }
      return modelAndNumberCarOfModel;
    }
  }
}  