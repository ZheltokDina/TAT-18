using System;
using System.Text;

namespace taskDEV2
{
  /// <summary>
  /// This class create substring with even indexes
  /// </summary>
  public class StringCreator
  {
    public string SequenceOfSymbols { get; set; }
    /// <summary>
    /// This constructor allows to create an object if the correct data is entered,
    /// in other case there will be exception
    /// </summary>
    /// <param name="sequenceOfSymbols">user input string</param>
    public StringCreator(string sequenceOfSymbols)
    {
      if (string.IsNullOrEmpty(sequenceOfSymbols))
      {
        throw new ArgumentNullException("Your string is empty");
      }
      SequenceOfSymbols = sequenceOfSymbols;
    }
    /// <summary>
    /// This method get a substring with even indexes
    /// </summary>
    /// <returns>substring with even indexes </returns>
    public string GetASubstringWithEvenIndexes()
    {
      StringBuilder substringWithEvenIndexes = new StringBuilder();
      for (int indexOfSymbol = 0; indexOfSymbol < SequenceOfSymbols.Length; indexOfSymbol += 2)
      {
        substringWithEvenIndexes.Append(SequenceOfSymbols[indexOfSymbol]);
      }
      return substringWithEvenIndexes.ToString();
    }
  }
}