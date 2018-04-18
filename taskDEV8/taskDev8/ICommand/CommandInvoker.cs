using System.Collections.Generic;

namespace taskDev8
{
  /// <summary>
  /// This class is the initiator of a сommand
  /// </summary>
  class CommandInvoker
  {
    private List<ICommand> listCommands = new List<ICommand>();
    public void SetCommand(ICommand command)
    {
      listCommands.Add(command);
    }
    public void Run()
    {
      foreach (ICommand command in listCommands)
      {
        command.Execute();
      }
    }
  }
}