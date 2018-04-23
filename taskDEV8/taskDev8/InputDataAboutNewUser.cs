using System;
using System.Collections.Generic;
using System.Linq;

namespace taskDev8
{
  /// <summary>
  /// This class is used for input data about new user
  /// </summary>
  class InputerDataAboutNewUser
  {
    public event EventHandler<NamesakeEventArg> Message;
    private List<User> listOfUsers;
    public InputerDataAboutNewUser(List<User> listOfUsers)
    {
      this.listOfUsers = listOfUsers;
    }
    /// <summary>
    /// This method is used for input data about new user 
    /// </summary>
    public User InputData()
    {
      Console.WriteLine("Please, input your data");
      Console.Write("Your name: ");
      string name = Console.ReadLine();
      Console.Write("Your surname: ");
      string surname = Console.ReadLine();
      Console.Write("Your sex of a person is <female> or <male> :");
      string selection = Console.ReadLine();
      User.SexOfAPerson sexOfAPerson = selection == "female" ? User.SexOfAPerson.female : User.SexOfAPerson.male;
      Console.Write("Your age: ");
      int age = Int32.Parse(Console.ReadLine());
      var usersSurname = from user in listOfUsers
                         select user.Surname;
      foreach (var userSurname in usersSurname)
      {
        if (surname.Equals(userSurname))
        {
          NamesakeEventArg args = new NamesakeEventArg();
          GetMessage(args);
        }
      }
      return new User(name, surname, sexOfAPerson, age);
    }
    protected virtual void GetMessage(NamesakeEventArg e)
    {
      EventHandler<NamesakeEventArg> handler = Message;
      if (handler != null)
      {
        handler(this, e);
      }
    }
  }
}