using System;
using System.Web.Services;

namespace taskWithWebService
{
  [WebService(Namespace = "http://tempuri.org/")]
  [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
  [System.ComponentModel.ToolboxItem(false)]
  /// <summary>
  /// This class is used for counting days, which passed from beginning of our era
  /// </summary>
  /// 
  public class WebService : System.Web.Services.WebService
  {
    [WebMethod]
    public int CountDays(DateTime dateTime)
    {
      return Convert.ToInt32((dateTime - DateTime.MinValue).TotalDays);
    }
  }
}