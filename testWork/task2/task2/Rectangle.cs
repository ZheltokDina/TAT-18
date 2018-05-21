using System;

namespace task2
{
  /// <summary>
  /// This class is used for count the square of the rectangle.
  /// </summary>
  public class Rectangle
  {
    private double rectangleLength;
    private double rectangleWidth;
    public double Length
    {
      get
      {
        return rectangleLength;
      }
      set
      {
        rectangleLength = value;
        if (rectangleLength <= 0)
        {
          throw new ArgumentException("The length shouldn't be equal or less than zero");
        }
      }
    }
    public double Width
    {
      get
      {
        return rectangleWidth;
      }
      set
      {
        rectangleWidth = value;
        if (rectangleWidth <= 0)
        {
          throw new ArgumentException("The width shouldn't be equal or less than zero");
        }        
      }
    }
    public Rectangle(string length, string width)
    {
      Length = double.Parse(length);
      Width = double.Parse(width);
    }
    /// <summary>
    /// This method is used for count the square of the rectangle.
    /// </summary>
    /// <returns> the square of the rectangle</returns>
    public double CountTheRectangleSquare()
    {
      return rectangleLength * rectangleWidth;
    }
  }
}