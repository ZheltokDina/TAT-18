using System;
using System.Text;

namespace taskDEV2
{
  /// <summary>
  /// This class create substring with even indexes
  /// </summary>
  class StringCreator
  {
    private string sequenceOfSymbols;
    public string SequenceOfSymbols
    {
      get
      {
        return sequenceOfSymbols;
      }
      set
      {
        sequenceOfSymbols = value;
        if (string.IsNullOrEmpty(sequenceOfSymbols))
        {
          throw new Exception("Your string is empty.");
        }
      }
    }

    /// <summary>
    ///  The trivial constructor 
    /// </summary>
    /// <param name="sequenceOfSymbols"> string entered from console</param>
    public StringCreator(string sequenceOfSymbols)
    {
      this.SequenceOfSymbols = sequenceOfSymbols;
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