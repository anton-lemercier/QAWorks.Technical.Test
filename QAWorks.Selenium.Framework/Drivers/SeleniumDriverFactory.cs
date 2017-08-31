using System;
using System.Collections.Generic;
using Coypu;
using Coypu.Drivers;
using Coypu.Drivers.Selenium;

namespace QAWorks.Selenium.Framework.Drivers
{
   public sealed class SeleniumDriverFactory : IDriverFactory
    {
        private readonly Dictionary<Tuple<string, string>, Type> _drivers;

       public SeleniumDriverFactory(ISupportedDrivers supportedDrivers)
        {
            _drivers = supportedDrivers.GetSupportedDrivers();
        }

        public Driver Create(string browser, string device)
        {
            var driverType = IsSupportedDriver(browser, device, out bool isSupportedDriver);

            if (isSupportedDriver)
            {
                return driverType == typeof(SeleniumWebDriver)
                    ? (SeleniumWebDriver)Activator.CreateInstance(driverType, Browser.Chrome)
                    : (CustomChromeDriver)Activator.CreateInstance(driverType, device);
            }

            throw new Exception($"The driver combination of browser: '{browser}' and device: '{device}' is not supported - Please check your app.config");
        }

        private Type IsSupportedDriver(string browser, string device, out bool isSupportedDriver)
        {
            isSupportedDriver = _drivers.TryGetValue(new Tuple<string, string>(browser, device), out Type driverType);
            return driverType;
        }
    }
}