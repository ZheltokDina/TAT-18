using System;

namespace task2
{
  /// <summary>
  /// The entry point of the programm
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        Rectangle rectangle = new Rectangle(args[0], args[1]);
        Console.WriteLine($"The square of rectangle is {rectangle.CountTheRectangleSquare()}");
      }
      catch(ArgumentException ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
