using System;
using System.Collections.Generic;
using System.IO;
using taskDev8.Command;

namespace taskDev8
{
  /// <summary>
  /// The entry point of the programm
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      List<User> listOfUsers = new List<User>();
      listOfUsers.Add(new User("Any", "Novik", User.SexOfAPerson.female, 18));
      listOfUsers.Add(new User("Natasha", "Lesh", User.SexOfAPerson.female, 64));
      listOfUsers.Add(new User("Ivan", "Morz", User.SexOfAPerson.male, 25));
      listOfUsers.Add(new User("Vlad", "Sed", User.SexOfAPerson.male, 40));

      InputerDataAboutNewUser usersData = new InputerDataAboutNewUser(listOfUsers);
      listOfUsers.Add(usersData.InputData());
      usersData.Message += GetNamesake;
      CommandReceiver receiver = new CommandReceiver(listOfUsers);
      OldestUser oldestUser = new OldestUser(receiver);
      TheMostPopularFemaleName popularFemaleName = new TheMostPopularFemaleName(receiver);
      UsersAverageAge averageAge = new UsersAverageAge(receiver);
      SelectCommand command = new SelectCommand(receiver);
      command.MenuCommand();
    }

    static void GetNamesake(object sender, NamesakeEventArg e)
    {
      Console.WriteLine("find a namesake");
    }
  }
}