using System;
using Coypu;
using QAWorks.Selenium.Framework.Drivers;
using QAWorks.Selenium.Framework.Helpers;

namespace QAWorks.Selenium.Framework
{
    public class CoypuDriver : IBrowserDriver
    {
        private readonly IDriverFactory _driverFactory;
        private readonly Options _defaultOptions = new Options { Timeout = new TimeSpan(0, 0, 5, 10) };
        private BrowserSession _browserSession;

        public CoypuDriver(IDriverFactory factory)
        {
            _driverFactory = factory;
            OpenBrowser();
        }
        
        public void OpenBrowser()
        {
            Driver driver = _driverFactory.Create(Settings.GetConfigValue("Browser"), Settings.GetConfigValue("Device"));

            _browserSession = new BrowserSession(driver);

            if (bool.Parse(Settings.GetConfigValue("MaximiseBrowser", "True")))
            {
                _browserSession.MaximiseWindow();
            }
        }

        public void NavigateToUrl(string url)
        {
            _browserSession.Visit(url);
        }

      public void CloseBrowser()
        {
            _browserSession.Dispose();
        }

        public void PopulateInput(string id, string input)
        {
            _browserSession.FindId(id, _defaultOptions).FillInWith(input);
        }

        public void ClickElementById(string id)
        {
            _browserSession.FindId(id).Click();
        }
        public void ClickElementByXpath(string xpath)
        {
           _browserSession.FindXPath(xpath).Click();
        }
        public string GetElementInnerHtmlById(string id, int pause = 0)
        {
            WaitHelper.Pause(pause);
            return _browserSession.FindId(id).InnerHTML;
        }
    }
}
