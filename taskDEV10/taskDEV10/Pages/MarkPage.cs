using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace taskDEV10.Pages
{
  /// <summary>
  /// This class works with the mark page
  /// </summary>
  public class MarkPage
  {
    private IWebDriver driver;
    Dictionary<string, int> modelAndNumberOfCars;

    public MarkPage(IWebDriver driver)
    {
      this.driver = driver;
    }

    /// <summary>
    /// This method writes to the dictionary models of machines and their number
    /// </summary>
    /// <returns></returns>
    public Dictionary<string, int> ListCars()
    {
      Locators locators = new Locators();
      modelAndNumberOfCars = new Dictionary<string, int>();
      WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
      foreach (IWebElement oneModel in waiter.Until(driver => driver.FindElements(By.XPath(locators.Model))))
      {
        modelAndNumberOfCars.Add((oneModel.FindElement(By.TagName("span")).Text), int.Parse(oneModel.FindElement(By.TagName("small")).Text));
      }
      return modelAndNumberOfCars;
    }

    /// <summary>
    /// This method sorts the models by their number.
    /// </summary>
    /// <param name="modelAndNumberCarOfModel"></param>
    /// <returns></returns>
    public Dictionary<string, int> SortedByNumberOfCars(Dictionary<string, int> modelAndNumberCarOfModel)
    {
      return modelAndNumberCarOfModel.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
    }
  }
}