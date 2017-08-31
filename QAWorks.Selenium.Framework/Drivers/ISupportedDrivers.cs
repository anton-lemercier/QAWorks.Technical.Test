using System;
using System.Collections.Generic;

namespace QAWorks.Selenium.Framework.Drivers
{
   public interface ISupportedDrivers
    {
       Dictionary<Tuple<string, string>, Type> GetSupportedDrivers();
    }
}