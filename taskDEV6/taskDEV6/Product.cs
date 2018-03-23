using System.Text;

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
 
    public Product( string type, string name, int count, double price)
    {
      Type = type;
      Name = name;
      Count = count;
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