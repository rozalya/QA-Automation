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
        String localDate = DateTime.Now.ToString();
        private static IWebDriver driver;

        public void TearLogs()
        {
            
            var path = AppDomain.CurrentDomain.BaseDirectory + "Logs\\";
            string filename = path + TestContext.CurrentContext.Test.Name + ".txt";
            string filenameJpg = path + TestContext.CurrentContext.Test.Name + ".jpg";
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            File.WriteAllText(filename, localDate + "::::: " + TestContext.CurrentContext.Test.MethodName + ":  "
                 + TestContext.CurrentContext.WorkDirectory + " :  "
                 + TestContext.CurrentContext.Result.PassCount + '\r'+'\n'
                 + TestContext.CurrentContext.Result.Message);

            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                if (File.Exists(filenameJpg))
                {
                    File.Delete(filenameJpg);
                }
                
                    var screenshot = ((ITakesScreenshot)this.Driver).GetScreenshot();
                    screenshot.SaveAsFile(filenameJpg, ScreenshotImageFormat.Jpeg);
              
            }


        }

    }
}
