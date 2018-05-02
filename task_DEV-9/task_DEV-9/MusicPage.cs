using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace task_DEV_9
{
  /// <summary>
  /// This class is used for output list of musics  
  /// </summary>
  class MusicPage
  {
    private ChromeDriver browser;
    public MusicPage(ChromeDriver browser)
    {
      this.browser = browser;
    }
    /// <summary>
    /// This method is used for output list of musics 
    /// </summary>
    public void GetListMusics()
    {
      IWebElement element = browser.FindElement(By.XPath("//*[@id='l_aud']"));
      element.Click();
      element = browser.FindElement(By.XPath("//*[@class ='audio_page__audio_rows_list" +
      " _audio_page__audio_rows_list _audio_pl audio_w_covers audio_owner_list_canedit']"));
      Console.WriteLine(element.Text);
    }
  }
}
