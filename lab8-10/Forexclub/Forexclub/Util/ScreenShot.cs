using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forexclub.Util
{
    public class ScreenShot
    {
        public static void MakeScreenShot()
        {
            Screenshot ss = ((ITakesScreenshot)DriverManager.GetWebDriver()).GetScreenshot();
            string path = DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss");

            try
            {
                ss.SaveAsFile(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName +
                    "/Forexclub/SavedLogs/" + path + ".png", ScreenshotImageFormat.Png);

                Log.Info("Screenshot is maken");
            }
            catch (Exception e)
            {
                Log.Info(e, "Screenshot isn't maken");
                throw;
            }
        }
    }
}
