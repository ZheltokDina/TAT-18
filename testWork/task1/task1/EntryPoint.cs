using System;

namespace task1
{/// <summary>
/// This class is used for output specified strings to the console,
///  the number of exclamation points is determined randomly in the last string
/// </summary>
  class EntryPoint
  {
    private const string HELLO_WORLD = "Hello, world!";
    private const string HI_AGAIN = "And hi again!";

    static void Main(string[] args)
    {
      Console.WriteLine(HELLO_WORLD);
      Console.WriteLine(HI_AGAIN);
      Random randon = new Random();
      string reapeatExclamationPoint = new string('!', randon.Next(5,10));
      Console.WriteLine(reapeatExclamationPoint);
    }
  }
}