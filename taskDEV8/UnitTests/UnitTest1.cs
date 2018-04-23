using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using taskDev8;

namespace UnitTests
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void AverageAgeTest()
    {
      List<User> listOfUsers = new List<User>();
      listOfUsers.Add(new User("Any", "Novik", User.SexOfAPerson.female, 18));
      listOfUsers.Add(new User("Natasha", "Lesh", User.SexOfAPerson.female, 64));
      listOfUsers.Add(new User("Ivan", "Morz", User.SexOfAPerson.male, 25));
      listOfUsers.Add(new User("Vlad", "Sed", User.SexOfAPerson.male, 40));
      listOfUsers.Add(new User("Natasha", "Lok", User.SexOfAPerson.female, 24));
      listOfUsers.Add(new User("Natasha", "Les", User.SexOfAPerson.female, 52));
      CommandReceiver receiver = new CommandReceiver(listOfUsers);
      int actualValue = receiver.SearchUsersAverageAge();
      Assert.AreEqual(37, actualValue);
    }
    [TestMethod]
    public void TheMostPopularFemaleNameTest()
    {
      List<User> listOfUsers = new List<User>();
      listOfUsers.Add(new User("Any", "Novik", User.SexOfAPerson.female, 18));
      listOfUsers.Add(new User("Natasha", "Lesh", User.SexOfAPerson.female, 64));
      listOfUsers.Add(new User("Ivan", "Morz", User.SexOfAPerson.male, 25));
      listOfUsers.Add(new User("Vlad", "Sed", User.SexOfAPerson.male, 40));
      listOfUsers.Add(new User("Natasha", "Lok", User.SexOfAPerson.female, 24));
      listOfUsers.Add(new User("Natasha", "Les", User.SexOfAPerson.female, 52));
      CommandReceiver receiver = new CommandReceiver(listOfUsers);
      string actualValue = receiver.SearchTheMostPopularFemaleName();
      Assert.AreEqual("Natasha", actualValue);
    }
    [TestMethod]
    public void PopularFemaleNameWhichNoFemaleNameTest()
    {
      List<User> listOfUsers = new List<User>();
      listOfUsers.Add(new User("Ivan", "Morz", User.SexOfAPerson.male, 25));
      listOfUsers.Add(new User("Vlad", "Sed", User.SexOfAPerson.male, 40));
      CommandReceiver receiver = new CommandReceiver(listOfUsers);
      string actualValue = receiver.SearchTheMostPopularFemaleName();
      Assert.AreEqual("", actualValue);
    }
    [TestMethod]
    public void TheOldestUserTest()
    {
      List<User> listOfUsers = new List<User>();
      listOfUsers.Add(new User("Any", "Novik", User.SexOfAPerson.female, 18));
      listOfUsers.Add(new User("Natasha", "Lesh", User.SexOfAPerson.female, 64));
      listOfUsers.Add(new User("Ivan", "Morz", User.SexOfAPerson.male, 25));
      listOfUsers.Add(new User("Vlad", "Sed", User.SexOfAPerson.male, 40));
      listOfUsers.Add(new User("Natasha", "Lok", User.SexOfAPerson.female, 24));
      listOfUsers.Add(new User("Natasha", "Les", User.SexOfAPerson.female, 52));
      CommandReceiver receiver = new CommandReceiver(listOfUsers);
      int actualValue = receiver.SearchOldestUser();
      Assert.AreEqual(64, actualValue);
    }
  }
}