using System;
using System.Text.RegularExpressions;

namespace taskDEV6
{
  /// <summary>
  /// This class is used for inputting information about products
  /// </summary>
  public class InputerInformationAboutProduct
  {
    public const string INPUT_DATA = "Please, input necessary data!";
    public const string TYPE_OF_PRODUCT = "Type of product:";
    public const string NAME_OF_PRODUCT = "Name of product:";
    public const string COUNT_OF_PRODUCT = "Count of product:";
    public const string PRICE_OF_PRODUCT = "Price of product:";

    /// <summary>
    /// This method is used for inputting information about products
    /// </summary>
    /// <returns></returns>
    public Product GetInformationAboutProduct()
    {
      Console.Clear();
      Console.WriteLine(INPUT_DATA);
      Console.Write(TYPE_OF_PRODUCT);
      string type = Console.ReadLine();
      if (!(Regex.IsMatch(type, "^[a-zA-Z ]+$")))
      {
        throw new FormatException("Uncorrent type of product.Please, try enter again!");
      }
      Console.Write(NAME_OF_PRODUCT);
      string name = Console.ReadLine();
      if (string.IsNullOrEmpty(name))
      {
        throw new FormatException("Uncorrent name of product.Please, try enter again!");
      }
      Console.Write(COUNT_OF_PRODUCT);
      int count = int.Parse(Console.ReadLine());
      if (count <= 0)
      {
        throw new FormatException("Uncorrent count of product.Please, try enter again!");
      }
      Console.Write(PRICE_OF_PRODUCT);
      double price = double.Parse(Console.ReadLine());
      if (price <= 0)
      {
        throw new FormatException("Uncorrent price of product.Please, try enter again!");
      }
      return new Product(type, name, count, price);
    }
  }
}