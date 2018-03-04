using System;
using System.Text;

namespace taskDEV2
{
  /// <summary>
  /// This class finds substring with even idices
  /// </summary>
  class StringCreater
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
    public StringCreater(string sequenceOfSymbols)
    {
      this.SequenceOfSymbols = sequenceOfSymbols;
    }

    /// <summary>
    /// This method finds substring with even idexes
    /// </summary>
    /// <returns>substring with even idexes </returns>
    public string CreateASubstringWithEvenIdices()
    {
      StringBuilder SubstringWithEvenIdexes = new StringBuilder();
      for (int indexOfSymbol = 0; indexOfSymbol < SequenceOfSymbols.Length; indexOfSymbol += 2)
      {
        SubstringWithEvenIdexes.Append(SequenceOfSymbols[indexOfSymbol]);
      }
      return SubstringWithEvenIdexes.ToString();
    }
  }
}