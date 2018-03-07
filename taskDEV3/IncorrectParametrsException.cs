using System;

namespace taskDEV3
{
  class IncorrectParametrsException : Exception
  {
    public override string Message => "Incorrect input data";
  }
}