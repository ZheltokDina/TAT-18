using System;
using System.Text;
using System.Text.RegularExpressions;

namespace taskDEV6
{
  /// <summary>
  /// This class is used to output information about products in the required format
  /// </summary>
  public class Product
  {
    public string Type { get; set; }
    public string Name { get; set; }
    public int Count { get; set; }
    public double Price { get; set; }

    public Product(string type, string name, int count, double price)
    {
      if (!(Regex.IsMatch(type, "^[a-zA-Z ]+$")))
      {
        throw new FormatException("Uncorrent type of product.Please, try enter again!");
      }
      Type = type;
      if (string.IsNullOrEmpty(name))
      {
        throw new FormatException("Uncorrent name of product.Please, try enter again!");
      }
      Name = name;
      if (count <= 0)
      {
        throw new FormatException("Uncorrent count of product.Please, try enter again!");
      }
      Count = count;
      if (price <= 0)
      {
        throw new FormatException("Uncorrent price of product.Please, try enter again!");
      }
      Price = price;
    }
    /// <summary>
    /// This method is used to output information about products in the required format
    /// </summary>
    /// <returns> string in the required format</returns>
    public string ReturnData()
    {
      StringBuilder builder = new StringBuilder();
      return builder.AppendLine($"Type of product: {Type}\nName of product: {Name}\n" +
      $"Count of product {Count}\nPrice of product: {Price}").ToString();
    }
  }
}