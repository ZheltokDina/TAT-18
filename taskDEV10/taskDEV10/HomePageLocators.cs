
namespace taskDEV10
{
  class HomePageLocators
  {
    public string showAllMark = "//*[@class = 'brands-all']";
    public string mark = "//*[@class=\"brandsitem brandsitem--primary\"]";
    public string CreateLocatorForMark(string mark)
    {
      return "//*[@class=\"brandsitem brandsitem--primary\"]//*[contains(text(),\"" + mark + "\")]";
    }
  }
}