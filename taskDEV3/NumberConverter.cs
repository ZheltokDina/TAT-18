using System.Text;

namespace taskDEV3
{
  /// <summary>
  /// This class is used for converting from one number system to another
  /// </summary>
  class NumberConverter
  {
    private const int NUMBER_TO_CHAR_START_POINT = 55;
    public int NumberInDecimalForm { get; private set; }
    public int Radix { get; private set; }

    public NumberConverter(int numberInDecimalForm, int radix)
    {
      if (radix < 2 || radix > 20)
      {
        throw new IncorrectParametrsException();
      }
      if (numberInDecimalForm <= 0)
      {
        throw new IncorrectParametrsException();
      }
      NumberInDecimalForm = numberInDecimalForm;
      Radix = radix;
    }

    /// <summary>
    /// This  method is used for converting from one number system to another
    /// </summary>
    /// <returns> convertible number</returns>
    public string ConvertNumberToNewRadix()
    {
      int bufferNumber = NumberInDecimalForm;
      StringBuilder numberInNewRadix = new StringBuilder();
      do
      {
        bufferNumber = NumberInDecimalForm / Radix;
        int remainder = NumberInDecimalForm % Radix;
        if (remainder < 10)
        {
          numberInNewRadix.Insert(0, remainder);
        }
        else
        {
          numberInNewRadix.Insert(0, (char)(NUMBER_TO_CHAR_START_POINT + remainder));
        }
        NumberInDecimalForm = bufferNumber;
      } while (bufferNumber != 0);
      return numberInNewRadix.ToString();
    }
  }
}