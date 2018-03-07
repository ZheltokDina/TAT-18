using System;

namespace taskDEV3
{
  class IncorrectDecimalNumberException : Exception
  {
    public override string Message => "Error: incorrect data of the decimal number";
  }
}
