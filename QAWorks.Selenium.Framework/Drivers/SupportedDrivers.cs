using System;
using System.Collections.Generic;
using Coypu.Drivers.Selenium;

namespace QAWorks.Selenium.Framework.Drivers
{
    public class SupportedDrivers : ISupportedDrivers
    {
        private readonly Dictionary<Tuple<string, string>, Type> _drivers = new Dictionary<Tuple<string, string>, Type>();

        public Dictionary<Tuple<string, string>, Type> GetSupportedDrivers()
        {
            _drivers.Add(new Tuple<string, string>("chrome", "Apple iPad"), typeof(CustomChromeDriver));
            _drivers.Add(new Tuple<string, string>("chrome", "Samsung Galaxy S4"), typeof(CustomChromeDriver));
            _drivers.Add(new Tuple<string, string>("chrome", "Apple iPhone 5"), typeof(CustomChromeDriver));
            _drivers.Add(new Tuple<string, string>("chrome", "desktop"), typeof(SeleniumWebDriver));

            return _drivers;
        }
    }
}