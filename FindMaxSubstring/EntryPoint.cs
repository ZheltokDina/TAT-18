using System;

namespace FindIdenticalConsecutiveCharacters
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
        WorkingWithString checker = new WorkingWithString(args[0]);
        checker.OutputResult(checker.FindMaxLengthOfIdenticalConsecutiveSymbols());
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}