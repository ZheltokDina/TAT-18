using System;

namespace taskDEV3
{
  class IncorrectRadixException : Exception
  {
    public override string Message => "Error: the radix doesn't lie in the permissible range";
  }
}