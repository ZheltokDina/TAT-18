using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace task_DEV_9
{
  /// <summary>
  /// This class is used for output list of friends
  /// </summary>
  class FriendsPage
  {
    private ChromeDriver browser;
    public FriendsPage(ChromeDriver browser)
    {
      this.browser = browser;
    }
    /// <summary>
    ///This class is used for output list of friends
    /// </summary>
    public void GetListFriends()
    {
      IWebElement element = browser.FindElement(By.XPath("//*[@id='l_fr']"));
      element.Click();
      element = browser.FindElement(By.XPath("//*[@id='friends_list']"));
      Console.WriteLine("list of friends:");
      Console.WriteLine(element.Text);
    }
  }
}