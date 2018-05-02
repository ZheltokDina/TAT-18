using OpenQA.Selenium.Chrome;

namespace task_DEV_9
{
  /// <summary>
  /// Home page  is the main page in VK
  /// </summary>
  public class HomePage
  {
    private ChromeDriver browser;
    public HomePage(ChromeDriver browser)
    {
      this.browser = browser;
    }
  }
}