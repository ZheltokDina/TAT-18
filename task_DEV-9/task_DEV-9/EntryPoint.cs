using OpenQA.Selenium.Chrome;

namespace task_DEV_9
{
  /// <summary>
  /// The entry point of the programm
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      ChromeDriver browser = new ChromeDriver();
      browser.Manage().Window.Maximize();
      LoginPage login = new LoginPage(browser);
      login.InputData("Dina_141@mail.ru", "Dina2014Jura");
      SelectCommand command = new SelectCommand(browser);
      command.MenuCommand();
      browser.Close();
    }
  }
}