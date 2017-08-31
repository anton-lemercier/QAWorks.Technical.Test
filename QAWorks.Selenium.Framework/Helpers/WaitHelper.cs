using System.Threading;

namespace QAWorks.Selenium.Framework.Helpers
{
   public static class WaitHelper
    {
     public static void Pause(int pause)
        {
            if (pause > 0)
            {
                Thread.Sleep(pause);
            }
        }
    }
}
