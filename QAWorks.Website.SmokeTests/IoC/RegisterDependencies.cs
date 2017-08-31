using BoDi;
using QAWorks.Selenium.Framework;
using QAWorks.Selenium.Framework.Drivers;
using TechTalk.SpecFlow;

namespace QAWorks.Website.SmokeTests.IoC
{
    /// <summary>
    /// Registers the driver with the Specflow dependency injection framework
    /// </summary>
    /// <remarks>
    /// Implements IoC using the SpecFlow's IObjectContainer and the built-in Scenario Context to inject step level dependencies
    /// documented here: http://specflow.org/documentation/Context-Injection/
    /// </remarks>
    [Binding]
    public sealed class RegisterDependencies
    {
        private readonly IObjectContainer _objectContainer;

        public RegisterDependencies(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void InitializeWebDriver()
        {
            _objectContainer.RegisterInstanceAs<ISupportedDrivers>(new SupportedDrivers());
            _objectContainer.RegisterInstanceAs<IDriverFactory>(new SeleniumDriverFactory(_objectContainer.Resolve<ISupportedDrivers>()));
            _objectContainer.RegisterInstanceAs<IBrowserDriver>(new CoypuDriver(_objectContainer.Resolve<IDriverFactory>()));
        }
    }
}
