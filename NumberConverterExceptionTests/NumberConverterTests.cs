using NUnit.Framework;

namespace taskDEV3.tests
{
  [TestFixture]
  public class NumberConverterTests
  {
    [Test]
    public void CheckForTheConversionNumberWhenRadixIsMaxAllowableValue()
    {
      NumberConverter converter = new NumberConverter(10, 20);
      Assert.AreEqual("A", converter.ConvertNumberToNewRadix());
    }
    [Test]
    public void CheckForTheConversionNumberWhenRadixIsMinAllowableValue()
    {
      NumberConverter converter = new NumberConverter(10, 2);
      Assert.AreEqual("1010", converter.ConvertNumberToNewRadix());
    }
    [Test]
    public void CheckForTheCorrectnessOfTheConvertedNumberWithLetters()
    {
      NumberConverter converter = new NumberConverter(86478, 16);
      Assert.AreEqual("151CE", converter.ConvertNumberToNewRadix());
    }
    [Test]
    public void CheckForTheCorrectConversionWhenTheEnteredNumberIsOne()
    {
      NumberConverter converter = new NumberConverter(1, 2);
      Assert.AreEqual("1", converter.ConvertNumberToNewRadix());
    }
    [Test]
    public void CheckForTheCorrectConversionWhenTheEnteredNumberIsZero()
    {
      NumberConverter converter = new NumberConverter(0, 16);
      Assert.AreEqual("0", converter.ConvertNumberToNewRadix());
    }
  }
}