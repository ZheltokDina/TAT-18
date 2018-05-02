using OpenQA.Selenium.Chrome;
using System;

namespace task_DEV_9
{
  /// <summary>
  /// This class is used for select command by user
  /// </summary>
  class SelectCommand
  {
    public ChromeDriver browser;
    public SelectCommand(ChromeDriver browser)
    {
      this.browser = browser;
    }
    /// <summary>
    /// This method is used to display commands
    /// </summary>
    public void MenuCommand()
    {
      do
      {
        Console.WriteLine("Select the number of the corresponding command: " +
          "\n1--look home page" +
          "\n2--output list of friends" +
          "\n3--output list of musics");
        string userCommand = Console.ReadLine();
        Command(userCommand);
        Console.WriteLine("If you want to choose another team,  press 'a'");
      } while (Console.ReadKey(true).KeyChar == 'a');
      return;
    }
    /// <summary>
    /// This method is used for select command by user
    /// </summary>
    /// <param name="userCommand"> command, which user entered</param>
    public void Command(string userCommand)
    {
      switch (userCommand)
      {
        case "1":
          NewsPage news = new NewsPage(browser);
          browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
          news.LookHomePage();
          break;
        case "2":
          FriendsPage friends = new FriendsPage(browser);
          browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
          friends.GetListFriends();
          break;
        case "3":
          MusicPage musics = new MusicPage(browser);
          browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
          musics.GetListMusics();
          break;
      }
    }
  }
}
