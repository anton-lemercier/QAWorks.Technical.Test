using Coypu;

namespace QAWorks.Selenium.Framework.Drivers
{
   public interface IDriverFactory
    {
       Driver Create(string browser, string device);
    }
}