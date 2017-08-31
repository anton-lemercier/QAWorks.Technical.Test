using System;
using Coypu.Drivers.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using QAWorks.Selenium.Framework.Drivers;

namespace QAWorks.Selenium.Framework.FrameworkTests
{
    [TestFixture]
    public class FrameworkDriverFactoryTests
    {
        private SeleniumDriverFactory _factory;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _factory = new SeleniumDriverFactory(new SupportedDrivers());
        }

        [TestCase("chrome", "Apple iPad", typeof(CustomChromeDriver))]
        [TestCase("chrome", "Apple iPhone 5", typeof(CustomChromeDriver))]
        [TestCase("chrome", "Samsung Galaxy S4", typeof(CustomChromeDriver))]
        [TestCase("chrome", "desktop", typeof(SeleniumWebDriver))]
        public void DriverFactory_Create_ReturnsCorrectDriver(string browser, string device, Type driverType)
        {
            var driver = _factory.Create(browser, device);

            var native = (RemoteWebDriver)driver.Native;

            Assert.IsInstanceOf(driverType, driver);
            Assert.AreEqual("chrome", native.Capabilities.BrowserName);

            driver.Dispose();
        }

        /// <summary>
        /// Ensures that an exception is thrown when the factory is asked to return a driver for an unsupported browser.
        /// </summary>
        [Test]
        public void DriverFactory_Create_ThrowsAnExceptionForUnsupportedBrowser()
        {
            var ex = Assert.Throws<Exception>(() => _factory.Create("unsupportedBrowser", "Apple iPad"));
            Assert.That(ex.Message.Contains("unsupportedBrowser"));
        }

        /// <summary>
        /// Ensures that an exception is thrown when the factory is asked to return a driver for unsupported device.
        /// </summary>
        [Test]
        public void DriverFactory_Create_ThrowsAnExceptionForUnsupportedDevice()
        {
            var ex = Assert.Throws<Exception>(() => _factory.Create("chrome", "unsupportedDevice"));
            Assert.That(ex.Message.Contains("unsupportedDevice"));
        }
    }
}