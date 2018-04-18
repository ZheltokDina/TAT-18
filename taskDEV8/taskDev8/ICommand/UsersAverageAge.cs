using System;

namespace taskDev8.Command
{
  class UsersAverageAge : ICommand
  {
    private CommandReceiver receiver;
    public UsersAverageAge(CommandReceiver receiver)
    {
      this.receiver = receiver;
    }
    public int averageAge;
    public void Execute()
    {
      averageAge = receiver.SearchUsersAverageAge();
      Console.WriteLine($"Average users' age is {averageAge}");
    }
  }
}