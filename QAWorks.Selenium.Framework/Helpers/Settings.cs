using System.Configuration;

namespace QAWorks.Selenium.Framework.Helpers
{
   public static class Settings
    {
      public static string GetConfigValue(string key, string defaultValue = null)
        {
            var configValue = ConfigurationManager.AppSettings[key];
            return string.IsNullOrEmpty(configValue) ? defaultValue : configValue;
        }
    }
}
