using System;
using System.Numerics;

namespace taskDEV3
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
        NumberConverter converter = new NumberConverter(BigInteger.Parse(args[0]), int.Parse(args[1]));        
        Console.WriteLine($"Convertible number is { converter.ConvertNumberToNewRadix()}");
      }
      catch (ArgumentOutOfRangeException ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}