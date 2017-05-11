using BartlettAreTheQAs.Models;
using BartlettAreTheQAs.Pages.Register_Page;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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
          
            var path = AppDomain.CurrentDomain.BaseDirectory + "Logs\\";
            string filename = path + TestContext.CurrentContext.Test.Name + ".txt";
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            File.WriteAllText(filename, TestContext.CurrentContext.Test.FullName + "        "
                 + TestContext.CurrentContext.WorkDirectory + "            "
                 + TestContext.CurrentContext.Result.PassCount+ "           "
                 + TestContext.CurrentContext.Result.Message);

            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                var screenshot = ((ITakesScreenshot)this.driver).GetScreenshot();
                screenshot.SaveAsFile(filename + TestContext.CurrentContext.Test.Name + ".jpg", ScreenshotImageFormat.Jpeg);
            }


        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void NavigatetoRegisterPage()
        {         
             RegisterPage RegPage = new RegisterPage(driver);
             RegPage.NavigateTo();
             Assert.IsTrue(RegPage.RegisterButton.Displayed);
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void RegisterInvalidEmail()
        {
            RegisterPage RegPage = new RegisterPage(this.driver);
            RegPage.NavigateTo();
            var userex = AccessExcelData.GetTestData("InvalidEmail");
            RegPage.FillRegistrationForm(userex);
            RegPage.AssertErrorMessage("The Email field is not a valid e-mail address.");
          
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void RegisterWihtoutEmail()
        {
            RegisterPage RegPage = new RegisterPage(this.driver);
            RegPage.NavigateTo();
            var userex = AccessExcelData.GetTestData("Register without mail");
            RegPage.FillRegistrationForm(userex);
            RegPage.AssertErrorMessage("The Email field is required.");

        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void RegisterAlreadyUsedEmail()
        {
            RegisterPage RegPage = new RegisterPage(this.driver);
            RegPage.NavigateTo();
            var userex = AccessExcelData.GetTestData("Register already used email");
            RegPage.FillRegistrationForm(userex);
            RegPage.AssertErrorMessage("The Email adress is already used");

        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void RegisterWithoutFullName()
        {
            RegisterPage RegPage = new RegisterPage(this.driver);
            RegPage.NavigateTo();
            var userex = AccessExcelData.GetTestData("Register without FullName");
            RegPage.FillRegistrationForm(userex);
            RegPage.AssertErrorMessage("The Full Name field is required.");

        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void RegisterWithoutPassword()
        {
            RegisterPage RegPage = new RegisterPage(this.driver);
            RegPage.NavigateTo();
            var userex = AccessExcelData.GetTestData("Register without Password");
            RegPage.FillRegistrationForm(userex);
            RegPage.AssertPasswordErrorMessage("The Password field is required.");

        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void RegisterWithoutComfirmPassword()
        {
            RegisterPage RegPage = new RegisterPage(this.driver);
            RegPage.NavigateTo();
            var userex = AccessExcelData.GetTestData("Register without Confirm password");
            RegPage.FillRegistrationForm(userex);
            RegPage.AssertPasswordErrorMessage("The Confirm Password field is required.");

        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void PasswordDoNotMatch()
        {
            RegisterPage RegPage = new RegisterPage(this.driver);
            RegPage.NavigateTo();
            var userex = AccessExcelData.GetTestData("Passwords do not match");
            RegPage.FillRegistrationForm(userex);
            RegPage.AssertPasswordErrorMessage("The password and confirmation password do not match.");

        }


    }
}
