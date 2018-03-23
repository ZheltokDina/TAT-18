﻿using System;
using System.Collections.Generic;

namespace taskDEV6
{
  /// <summary>
  /// This class considers general number of products
  /// </summary>
  public class CountAllStrategy : IStrategy
  {
    /// <summary>
    /// This method considers general number of products
    /// </summary>
    public void Do(List<Product> products, string type)
    {
      int countAllProducts = 0;
      foreach (var product in products)
      {
        countAllProducts += product.Count;
      }
      Console.WriteLine($"Count all of products is {countAllProducts}");
    }
  }
}