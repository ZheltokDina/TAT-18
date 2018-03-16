using NUnit.Framework;
using System;

namespace taskDEV3.tests
{
  [TestFixture]
  public class NumberConverterExceptionTests
  {
    [Test]
    public void CheckForExceptionWhenRadixLessThanAllowableValue()
    {
      Assert.Throws<ArgumentOutOfRangeException>
       (
          () => new NumberConverter(10, 1)
       );
    }
    [Test]
    public void CheckForExceptionWhenRadixMoreThanAllowableValue()
    {
      Assert.Throws<ArgumentOutOfRangeException>
       (
          () => new NumberConverter(55, 21)
       );
    }
    [Test]
    public void CheckForExceptionWhenNumberInDecimalFormLessThanAllowableValue()
    {
      Assert.Throws<ArgumentOutOfRangeException>
       (
          () => new NumberConverter(-1, 2)
       );
    }
  }
}