using QAWorks.Selenium.Framework;
using QAWorks.Selenium.Framework.Helpers;

namespace QAWorks.Website.SmokeTests.PageModels
{
    public class HomePageModel
    {
         private readonly IBrowserDriver _driver;
        private const string ContactUsMenuItemElementXpath = "//*[@id=\"menu\"]/li[1]/a";
        
        public HomePageModel(IBrowserDriver driver)
        {
            _driver = driver;
        }

      public void NavigateToPage()
        {
            this._driver.NavigateToUrl(Settings.GetConfigValue("HomePageUrl"));
        }

        public void NavigateToContactUsPage()
        {
            this._driver.ClickElementByXpath(ContactUsMenuItemElementXpath);
        }
    }
}
