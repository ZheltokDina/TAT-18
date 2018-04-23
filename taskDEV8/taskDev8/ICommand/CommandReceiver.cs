using System.Collections.Generic;
using System.Linq;

namespace taskDev8
{
  /// <summary>
  ///  This class is the recipient  of a сommand
  /// </summary>
  public class CommandReceiver
  {
    private List<User> listOfUsers;
    public CommandReceiver(List<User> listOfUsers)
    {
      this.listOfUsers = listOfUsers;
    }
    /// <summary>
    /// This method searches for the most oldest user
    /// </summary>
    /// <returns>the most oldest user</returns>
    public int SearchOldestUser()
    {
      var oldestAge = from user in listOfUsers
                            select user.Age;
    return oldestAge.Max();
    }
    /// <summary>
    /// This method searches for the most popular female name
    /// </summary>
    /// <returns>the most popular female name</returns>
    public string SearchTheMostPopularFemaleName()
    {
      var femaleName = from user in listOfUsers
                       where user.Sex == User.SexOfAPerson.female
                       orderby user.Name
                       select user.Name;
      string[] arrayFemaleName = femaleName.ToArray();
      string popularFemaleName = string.Empty;
      int count = 0;
      int byfferCount = 0;
      for (int j = 0; j < arrayFemaleName.Length - 1; j++)
      {
        if (arrayFemaleName[j] == arrayFemaleName[j + 1])
        {
          byfferCount++;
        }
        if (count < byfferCount)
        {
          popularFemaleName = arrayFemaleName[j];
          count = byfferCount;
        }
      }
      return popularFemaleName;
    }
    /// <summary>
    /// This method count average age all users
    /// </summary>
    /// <returns>average age all users</returns>
    public int SearchUsersAverageAge()
    {
      var usersAverageAge = from user in listOfUsers
                            select user.Age;
      return (int)usersAverageAge.Average();
    }
  }
}