using System;
using taskDev8.Command;

namespace taskDev8
{
  /// <summary>
  /// This class is used for select command by user
  /// </summary>
  class SelectCommand
  {
    private CommandReceiver receiver;
    public SelectCommand(CommandReceiver receiver)
    {
      this.receiver = receiver;
    }
    CommandInvoker commandInvoker = new CommandInvoker();
    /// <summary>
    /// This method is used to display commands
    /// </summary>
    public void MenuCommand()
    {
      do
      {
        Console.WriteLine("Select the number of the corresponding command: " +
          "\n1--average age of users" +
          "\n2--oldest user" +
          "\n3--the most popular female name");
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
          commandInvoker.SetCommand(new UsersAverageAge(receiver));
          commandInvoker.Run();
          break;
        case "2":
          commandInvoker.SetCommand(new OldestUser(receiver));
          commandInvoker.Run();
          break;
        case "3":
          commandInvoker.SetCommand(new TheMostPopularFemaleName(receiver));
          commandInvoker.Run();
          break;
      }
    }
  }
}