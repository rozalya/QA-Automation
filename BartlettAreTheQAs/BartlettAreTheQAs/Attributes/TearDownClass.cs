using BartlettAreTheQAs.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs.Attributes
{
    public class TearDownClass : BasePage
    {
        public TearDownClass(IWebDriver driver) : base(driver)
        {
        }
        private static IWebDriver driver;

        public void TearLogs()
        {
            //   var path = AppDomain.CurrentDomain.BaseDirectory + "Logs\\";
            string path = ConfigurationManager.AppSettings["Logs"];
            path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
            string filename = path + TestContext.CurrentContext.Test.Name + ".txt";
            string filenameJpg = path + TestContext.CurrentContext.Test.Name + ".jpg";
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            string WriteToString = string.Format("[ {0} ] [ {1} ] [ {2} ] :: {3} ", DateTime.Now, 
                TestContext.CurrentContext.Result.Outcome.Status,
                TestContext.CurrentContext.Test.MethodName,TestContext.CurrentContext.Result.Message);

            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                filename = path + TestContext.CurrentContext.Test.Name + "  [FAILED] " + ".txt"; ;         
                File.WriteAllText(filename, WriteToString);

            }
            else
            {
                File.WriteAllText(filename, WriteToString);
            }
            

            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                if (File.Exists(filenameJpg))
                {
                    File.Delete(filenameJpg);
                }
                filenameJpg = path + TestContext.CurrentContext.Test.Name + "  [FAILED] " + ".jpg"; 
                var screenshot = ((ITakesScreenshot)this.Driver).GetScreenshot();
                screenshot.SaveAsFile(filenameJpg, ScreenshotImageFormat.Jpeg);

            }

        }

    }

}

