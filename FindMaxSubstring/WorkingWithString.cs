using System;

namespace FindIdenticalConsecutiveCharacters
{
  /// <summary>
  /// This class finds the maximum number of identical consecutive characters in the string
  /// </summary>
  public class WorkingWithString
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
    /// The trivial constructor with ToUpper() method 
    /// </summary>
    /// <param name="sequenceOfSymbols">string entered by the user</param>
    public WorkingWithString(string userString)
    {
      this.SequenceOfSymbols = userString.ToUpper();
    }

    /// <summary>
    /// This method is used for finding maximum length of identical consecutive characters in the string
    /// </summary>
    /// <returns>return maximum length of identical consecutive characters in the string</returns>
    public int FindMaxLengthOfIdenticalConsecutiveSymbols()
    {
      int maxLengthCount = 0;
      int currentCount = 1;
      for (int i = 0; i < SequenceOfSymbols.Length - 1; i++)
      {
        if (SequenceOfSymbols[i].Equals(SequenceOfSymbols[i + 1]))
        {
          currentCount++;
        }
        else
        {
          currentCount = 1;
        }
        if (currentCount > maxLengthCount)
        {
          maxLengthCount = currentCount;
        }
      }
      return maxLengthCount;
    }

    /// <summary>
    /// Is used for console output 
    /// </summary>
    /// <param name="resultLenght">the resulting  number of identical consecutive characters</param>
    public void OutputResult(int resultLenght)
    {
      Console.WriteLine(resultLenght.ToString());
    }
  }
}