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
      string sequenceOfSymbols;
      do
      {
        Console.WriteLine("Please, enter a non-empty string:");
        sequenceOfSymbols = Console.ReadLine();
      } while (String.IsNullOrEmpty(sequenceOfSymbols));

      StringCreator creator = new StringCreator();
      Console.WriteLine(creator.GetASubstringWithEvenIndexes(sequenceOfSymbols));
    }
  }
}