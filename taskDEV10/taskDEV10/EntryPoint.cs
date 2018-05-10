using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using taskDEV10.Pages;

namespace taskDEV10
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      IWebDriver driver = new ChromeDriver();
      driver.Manage().Window.Maximize();
      driver.Navigate().GoToUrl("https://av.by/");
      HomePage homePage = new HomePage(driver, args[0]);
      if (homePage.CheckForThePresenceOfThisMark())
      {
        homePage.EstablishMark();
        MarkPage markPage = new MarkPage(driver);
        Console.WriteLine(markPage.ReadAllModelWithNumberOfCarThisModel());
      }
      else
      {
        Console.WriteLine("Please, to check the mark spelling");
      }
    }
  }
}