using Coypu.Drivers;
using Coypu.Drivers.Selenium;
using OpenQA.Selenium.Chrome;

namespace QAWorks.Selenium.Framework.Drivers
{
    public sealed class CustomChromeDriver : SeleniumWebDriver
    {
        private static readonly ChromeOptions ChromeOptions = new ChromeOptions();

        public CustomChromeDriver(string device)
            : base(ConfigureChromeDriver(device), Browser.Chrome)
        {
        }

        private static ChromeDriver ConfigureChromeDriver(string device)
        {
            //ChromeOptions.EnableMobileEmulation(device);
            return new ChromeDriver(ChromeOptions);
        }
    }
}