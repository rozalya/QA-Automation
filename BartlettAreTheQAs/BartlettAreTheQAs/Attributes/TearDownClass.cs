using BartlettAreTheQAs.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs.Attributes
{
 public   class TearDownClass: BasePage
    {
        public TearDownClass(IWebDriver driver) : base(driver)
        {
        }

        public void TearLogs()
        {

            var path = AppDomain.CurrentDomain.BaseDirectory + "Logs\\";
            string filename = path + TestContext.CurrentContext.Test.Name + ".txt";
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            File.WriteAllText(filename, TestContext.CurrentContext.Test.FullName + "        "
                 + TestContext.CurrentContext.WorkDirectory + "            "
                 + TestContext.CurrentContext.Result.PassCount + "           "
                 + TestContext.CurrentContext.Result.Message);

            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                var screenshot = ((ITakesScreenshot)this.Driver).GetScreenshot();
                screenshot.SaveAsFile(filename + TestContext.CurrentContext.Test.Name + ".jpg", ScreenshotImageFormat.Jpeg);
            }


        }

    }
}
