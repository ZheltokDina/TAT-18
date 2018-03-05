using System.Text;

namespace taskDEV2
{
  /// <summary>
  /// This class create substring with even indexes
  /// </summary>
  class StringCreator
  {
    /// <summary>
    /// This method get a substring with even indexes
    /// </summary>
    /// <returns>substring with even indexes </returns>
    public string GetASubstringWithEvenIndexes(string sequenceOfSymbols)
    {
      StringBuilder substringWithEvenIndexes = new StringBuilder();
      for (int indexOfSymbol = 0; indexOfSymbol < sequenceOfSymbols.Length; indexOfSymbol += 2)
      {
        substringWithEvenIndexes.Append(sequenceOfSymbols[indexOfSymbol]);
      }
      return substringWithEvenIndexes.ToString();
    }
  }
}