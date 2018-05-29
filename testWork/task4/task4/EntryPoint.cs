using System;
using System.Collections.Generic;

namespace task4
{
  /// <summary>
  /// The entry point Of the programm
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Please, input your name:");
      string name = Console.ReadLine();
      Console.WriteLine("Input your surname:");
      string surname = Console.ReadLine();
      Console.WriteLine("Input your age:");
      int age = int.Parse(Console.ReadLine());    
    
      List<User> listOfUsers = new List<User>();
      listOfUsers.Add(new User(name, surname, age));
      SearchDifferentAge search = new SearchDifferentAge(listOfUsers);
      foreach (User user in listOfUsers)      {
        Console.WriteLine(name, surname);
      }
      Console.WriteLine($"Age the  youngest user is {search.SearchYoungestUserAge()}");
      Console.WriteLine($"Age the oldest user is {search.SearchOldestUserAge()}");
      Console.WriteLine($"Average age users is {search.SearchUsersAverageAge()}");    
    }
  }
}