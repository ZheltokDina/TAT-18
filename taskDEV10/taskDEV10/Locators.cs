
namespace taskDEV10
{
  class Locators
  {
    public string ShowAllMark
    {
      get
      {
        return "//*[@class = 'brands-all']";
      }
    }
    public string Mark
    {
      get
      {
        return "//ul[@class='brandslist']//li[contains(@class, 'brandsitem')]/a";
      }
    }
    public string Model
    {
      get
      {
        return "//*[@class=\"brandsitem brandsitem--primary\"]";
      }
    }
    public string FindAdvertising
    {
      get
      {
        return "//div[@class = 'survey-popup js-survey-popup survey-popup--visible']";
      }
    }
    public string CloseAdvertising
    {
      get
      {
        return "//span[@class = 'survey-popup-close js-survey-popup-close']";
      }
    }
    public string CreateLocatorForMark(string mark)
    {
      return "//a[@href = 'https://cars.av.by/" + mark.ToLower() + "']";
    }
  }
}