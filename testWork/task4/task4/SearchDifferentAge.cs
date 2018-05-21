using System.Collections.Generic;
using System.Linq;

namespace task4
{
  class SearchDifferentAge
  {
    private List<User> listOfUsers;
    public SearchDifferentAge(List<User> listOfUsers)
    {
      this.listOfUsers = listOfUsers;
    }
    public int SearchYoungestUserAge()
    {
      var oldestAge = from user in listOfUsers
                      select user.Age;
      return oldestAge.Min();
    }
    public int SearchOldestUserAge()
    {
      var oldestAge = from user in listOfUsers
                      select user.Age;
      return oldestAge.Max();
    }
    public int SearchUsersAverageAge()
    {
      var usersAverageAge = from user in listOfUsers
                            select user.Age;
      return (int)usersAverageAge.Average();
    }
  }
}