using System;

namespace taskDev8.Command
{
  class OldestUser : ICommand
  {
    private CommandReceiver receiver;
    public OldestUser(CommandReceiver receiver)
    {
      this.receiver = receiver;
    }
    private int theOldestUser;
    public void Execute()
    {
     theOldestUser = receiver.SearchOldestUser();
     Console.WriteLine($"the oldest user {theOldestUser} years old");
    }
  }
}