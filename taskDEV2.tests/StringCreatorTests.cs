using System;
using Xunit;

namespace taskDEV2.tests
{
  public class StringCreatorTests
  {
    [Fact]
    public void CheckForTheFormationOfTheCorrectSubstring()
    {
      StringCreator creator = new StringCreator("abcdef");
      Assert.Equal("ace", creator.GetASubstringWithEvenIndexes());
    }
    [Fact]
    public void CheckForAStringThatContainsOneSymbol()
    {
      StringCreator creator = new StringCreator("a");
      Assert.Equal("a", creator.GetASubstringWithEvenIndexes());
    }
    [Fact]
    public void CheckTheCorrectnessThrownException()
    {
      Assert.Throws<ArgumentNullException>
        (
          () => new StringCreator(String.Empty)
        );
    }
  }
}