using BartlettAreTheQAs.Pages.Register_Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs
{
    [TestFixture]
    class BlogRegisterPageTests
    {
        public IWebDriver driver;
        [SetUp]

        public void Initialized()
        {
            this.driver = BrowserHost.Instance.Application.Browser;
        }

        [TearDown]
        public void LogsandScreenshot()
        {
            // Don't close the driver because of TeamCity  
            //driver.Close();

        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void NavigatetoRegisterPage()
        {         
             RegisterPage RegPage = new RegisterPage(driver);
             RegPage.NavigateTo();
             Assert.IsTrue(RegPage.RegisterButton.Displayed);
        }

    }
}
