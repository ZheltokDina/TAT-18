using System;
using System.Collections.Generic;

namespace taskDEV6
{
  /// <summary>
  /// The entry point of the programm
  /// </summary>
  class EntryPoint
  {
    public const string ADDING_A_TYPE_OF_PRODUCT = "Do you want to add another type of product?\n" +
    "If <YES> press any key, if <NOT> press escape";
    static void Main(string[] args)
    {
      List<Product> products = new List<Product>();
      do
      {
        try
        {
          InputerInformationAboutProduct inputer = new InputerInformationAboutProduct();
          products.Add(inputer.GetInformationAboutProduct());
        }
        catch (FormatException ex)
        {
          Console.WriteLine(ex.Message);
          continue;
        }
        Console.WriteLine(ADDING_A_TYPE_OF_PRODUCT);
      } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
      Console.Clear();
      OutputerInformationAboutProduct outputer = new OutputerInformationAboutProduct();
      outputer.DisplayInformation(products);
      Console.Clear();
      Warehouse command = new Warehouse(products);
      command.DisplayCommand();
      command.ChooseCommand();
    }
  }
}