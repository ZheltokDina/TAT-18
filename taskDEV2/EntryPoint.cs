using System;

namespace taskDEV2
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
        Console.WriteLine("Please, enter a string:");
        string sequenceOfSymbols = Console.ReadLine();
        StringCreator creator = new StringCreator(sequenceOfSymbols);
        Console.WriteLine(creator.GetASubstringWithEvenIdexes());
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}