using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace task_DEV_9
{
  /// <summary>
  /// News page is the next page after enter to VK
  /// </summary>
  public class NewsPage
  {
    private ChromeDriver browser;
    public NewsPage(ChromeDriver browser)
    {
      this.browser = browser;
    }
    /// <summary>
    /// This method is used to view the home page
    /// </summary>
    /// <returns></returns>
    public HomePage LookHomePage()
    {
     IWebElement element = browser.FindElement(By.XPath("//*[@id='l_pr']"));
     element.Click();
     return new HomePage(browser);
    }
  }
}