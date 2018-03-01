using System;

namespace FindMaxSubstring
{
  /// <summary>
  /// This class finds maximum number of the same elements in the substring
  /// </summary>
  public class LengthChecker
  {
    private string userString;
    public string UserString
    {
      get
      {
        return userString;
      }
      set
      {
        userString = value;
        if (string.IsNullOrEmpty(userString))
        {
          throw new Exception("Your string is empty.");
        }
      }
    }

    /// <summary>
    /// The trivial constructor with ToUpper() method 
    /// </summary>
    /// <param name="userChecker"></param>
    public LengthChecker(string userString)
    {
      this.UserString = userString.ToUpper();
    }

    /// <summary>
    /// This method is used for finding maximum length of the substring
    /// </summary>
    /// <returns></returns>
    public int FindMaxLengthOfSubstring() 
    {
      int maxLengthCount = 0;
      int currentCount = 0;
      for (int i = 0; i < UserString.Length - 1; i++)
      {
        if (UserString[i].Equals(UserString[i + 1]))
        {
          currentCount++;                             
        }
        if (!UserString[i].Equals(UserString[i + 1]))
        {
          currentCount = 0;                         
        }
        else if(currentCount > maxLengthCount)        
        {
          maxLengthCount = currentCount;              
        }
      }
      return maxLengthCount + 1;
    }

    /// <summary>
    /// Is used for console output 
    /// </summary>
    /// <param name="resultLenght">which is displayed</param>
    public void OutputResult(int resultLenght)
    {
      Console.WriteLine(resultLenght.ToString());
    }
  }
}
