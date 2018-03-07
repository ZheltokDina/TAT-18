using System;

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
        int numberInDecimalForm = int.Parse(args[0]);
        int radix = int.Parse(args[1]);
        NumberConverter converter = new NumberConverter(numberInDecimalForm, radix);
        string convertibleNumber = converter.ConvertNumberToNewRadix();
        Console.WriteLine($"Convertible number is { convertibleNumber}");
      }
      catch (FormatException ex)
      {
        Console.WriteLine(ex.Message);
      }
      catch (ArgumentOutOfRangeException ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}