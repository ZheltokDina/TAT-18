using System;

namespace taskDev8.Command
{
  class TheMostPopularFemaleName : ICommand
  {
    private CommandReceiver receiver;
    public TheMostPopularFemaleName(CommandReceiver receiver)
    {
      this.receiver = receiver;
    }
    public string popularFemaleName;
    public void Execute()
    {
      popularFemaleName = receiver.SearchTheMostPopularFemaleName();
      Console.WriteLine($"The most popular female name is {popularFemaleName}");
    }
  }
}