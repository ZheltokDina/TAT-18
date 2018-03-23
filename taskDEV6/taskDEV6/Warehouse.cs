using System;
using System.Collections.Generic;

namespace taskDEV6
{
  /// <summary>
  /// This class is used for select a command by the user
  /// </summary>
  public class Warehouse
  {
    public const string CHOOSE_COMMAND = "Please, write one of the command";
    public const string COUNT_TYPES = "Count types";
    public const string COUNT_ALL = "Count all";
    public const string AVERAGE_PRICE = "Average price";
    public const string AVERAGE_PRICE_TYPE = "Average price type";
    public const string EXIT = "Exit";
    public const int FIRST_LETTER_OF_TYPE = 1;

    private IStrategy ExecuteMetod;
    private List<Product> products;

    public Warehouse(List<Product> products)
    {
      this.products = products;
    }
    /// <summary>
    /// This method is used to display commands
    /// </summary>
    public void DisplayCommand()
    {
      Console.WriteLine(COUNT_TYPES);
      Console.WriteLine(COUNT_ALL);
      Console.WriteLine(AVERAGE_PRICE);
      Console.WriteLine(AVERAGE_PRICE_TYPE);
      Console.WriteLine(EXIT);
    }

    /// <summary>
    /// This method is used for select a command by the user
    /// </summary>
    public void ChooseCommand()
    {
      Console.WriteLine(CHOOSE_COMMAND);
      string currentCommand = string.Empty;
      while (true)
      {
        currentCommand = Console.ReadLine();
        if (currentCommand.Equals(EXIT))
        {
          break;
        }
        if (currentCommand.Equals(COUNT_TYPES))
        {
          ExecuteMetod = new CountTypesStrategy();
          ExecuteMetod.Do(products);
          continue;
        }
        if (currentCommand.Equals(COUNT_ALL))
        {
          ExecuteMetod = new CountAllStrategy();
          ExecuteMetod.Do(products);
          continue;
        }
        if (currentCommand.Equals(AVERAGE_PRICE))
        {
          ExecuteMetod = new AveragePriceStrategy();
          ExecuteMetod.Do(products);
          continue;
        }
        if (currentCommand.Length >= AVERAGE_PRICE.Length)
        {
          if ((currentCommand.Substring(0, AVERAGE_PRICE.Length) == AVERAGE_PRICE) && (currentCommand.Length - AVERAGE_PRICE.Length >= FIRST_LETTER_OF_TYPE))
          {
            string type = currentCommand.Substring(AVERAGE_PRICE.Length + FIRST_LETTER_OF_TYPE);
            ExecuteMetod = new AveragePriceTypeStrategy();
            ExecuteMetod.Do(products, type);
            continue;
          }
        }
        else
        {
          Console.WriteLine("This command does not exist.Try again");
        }
      }
    }
  }
}