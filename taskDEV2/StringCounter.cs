using System;
using System.Text;

namespace taskDEV2
{
  /// <summary>
  /// This class finds substring with even idices
  /// </summary>
  class StringCounter
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
    public StringCounter(string sequenceOfSymbols)
    {
      this.SequenceOfSymbols = sequenceOfSymbols;
    }

    /// <summary>
    /// This method finds substring with even idices
    /// </summary>
    /// <returns>substring with even idices </returns>
    public string FindASubstringWithEvenIdices()
    {
      StringBuilder line = new StringBuilder();
      for (int indexOfSymbol = 0; indexOfSymbol < SequenceOfSymbols.Length; indexOfSymbol++)
      {
        if (indexOfSymbol % 2 == 0)
        {
          line.Append(SequenceOfSymbols[indexOfSymbol]);
        }
      }
      return line.ToString();
    }
  }
}