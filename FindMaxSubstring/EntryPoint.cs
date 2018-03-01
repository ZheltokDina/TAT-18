using System;

namespace FindMaxSubstring
{
  /// <summary>
  /// The entry point of the programm
  /// </summary>
  class EntryPoint
  {
    /// <summary>
    /// For calling the main methods for check the user's string
    /// </summary>
    /// <param name="args">from command line</param>
    static void Main(string[] args)
    {
      try
      {
        LengthChecker checker = new LengthChecker(args[0]);
        checker.OutputResult(checker.FindMaxLengthOfSubstring());
      }
      catch(Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
