using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace task_DEV_9
{
  /// <summary>
  /// This class is used to enter the VK
  /// </summary>
  public class LoginPage
  {
    private ChromeDriver browser;
    public LoginPage(ChromeDriver browser)
    {
      this.browser = browser;
    }
    /// <summary>
    /// This method is used to enter the VK
    /// /// </summary>
    public void InputData(string login, string password)
    {
      browser.Navigate().GoToUrl("https://vk.com/login?act=mobile&hash=ca2002c37c8fffdf8b90787945fd");
      IWebElement element = browser.FindElement(By.Id("quick_email"));
      element.SendKeys(login);
      element = browser.FindElement(By.Id("quick_pass"));
      element.SendKeys(password);
      element = browser.FindElement(By.Id("quick_login_button"));
      element.Click();
    }
  }
}
