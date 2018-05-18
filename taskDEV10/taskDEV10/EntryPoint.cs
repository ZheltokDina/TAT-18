using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using taskDEV10.Pages;

namespace taskDEV10
{
  /// <summary>
  /// The entry point of the programm
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      IWebDriver driver = new ChromeDriver();
      driver.Manage().Window.Maximize();
      driver.Navigate().GoToUrl("https://av.by/");
      string mark = args[0];
      HomePage homePage = new HomePage(driver, mark);
      try
      {
        homePage.CloseAdvertising();
        MarkPage markPage = homePage.NavigateToMarkPage();
        var modelAndNumberCarOfModel = markPage.ListCars();
        var sortedList = markPage.SortedByNumberOfCars(modelAndNumberCarOfModel);
        foreach (var element in sortedList)
        {
          Console.WriteLine($"Model: {element.Key}-- Number of cars: {element.Value}");
        }
      }
      catch (NotFoundException ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}