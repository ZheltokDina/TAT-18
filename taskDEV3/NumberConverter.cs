using System;
using System.Text;
using System.Numerics;

namespace taskDEV3
{
  /// <summary>
  /// This class is used for converting from decimal number system to another
  /// </summary>
  public class NumberConverter
  {
    private const int NUMBER_TO_CHAR_START_POINT = 55;
    public BigInteger NumberInDecimalForm { get; private set; }
    public int Radix { get; private set; }

    /// <summary>
    /// This constructor allows to create an object if the correct data is entered,
    /// in other case there will be exception
    /// </summary>
    /// <param name="numberInDecimalForm">the number for transformation </param>
    /// <param name="radix">radix in which necessary to transform</param>
    public NumberConverter(BigInteger numberInDecimalForm, int radix)
    {
      if (radix < 2 || radix > 20 || numberInDecimalForm < 0)
      {
        throw new ArgumentOutOfRangeException();
      }
      NumberInDecimalForm = numberInDecimalForm;
      Radix = radix;
    }
    
    /// <summary>
    /// This  method is used for converting from decimal number system to another
    /// </summary>
    /// <returns> convertible number</returns>
    public string ConvertNumberToNewRadix()
    {
      BigInteger bufferNumber = NumberInDecimalForm;
      StringBuilder numberInNewRadix = new StringBuilder();
      if(NumberInDecimalForm.IsZero)
      {
        numberInNewRadix.Append(0);
      }
      if (NumberInDecimalForm.IsOne)
      {
        numberInNewRadix.Append(1);
      }
      else
      {
        while (bufferNumber != 0)
        {
          bufferNumber = NumberInDecimalForm / Radix;
          BigInteger remainder = NumberInDecimalForm % Radix;
          if (remainder < 10)
          {
            numberInNewRadix.Insert(0, remainder);
          }
          else
          {
            numberInNewRadix.Insert(0, (char)(NUMBER_TO_CHAR_START_POINT + remainder));
          }
          NumberInDecimalForm = bufferNumber;
        } 
      }
      return numberInNewRadix.ToString();
    }
  }
}