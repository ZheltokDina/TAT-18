
namespace taskDev8
{
  /// <summary>
  /// This class is used to initialize properties
  /// </summary>
  public class User
  {
    public enum SexOfAPerson
    {
      female,
      male
    }
    public string Name { get; set; }
    public string Surname { get; set; }
    public SexOfAPerson Sex { get; set; }
    public int Age { get; set; }

    public User(string name, string surname, SexOfAPerson sexOfAPerson, int age)
    {
      Name = name;
      Surname = surname;
      Sex = sexOfAPerson;
      Age = age;
    }
  }
}