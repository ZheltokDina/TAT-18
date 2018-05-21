using System;
using taskWithWebService;

namespace CerviceClients
{
  /// <summary>
  /// The entry point of the programm
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Please, enter datу in format YYYY,MM,DD");
      DateTime dateTime = DateTime.Parse(Console.ReadLine());
      WebService webService = new WebService();
      Console.WriteLine($"{webService.CountDays(dateTime)} number of days, passed from the beginning of our era");
    }
  }
}