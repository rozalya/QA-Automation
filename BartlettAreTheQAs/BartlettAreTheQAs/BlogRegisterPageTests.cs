using BartlettAreTheQAs.Attributes;
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
        public RegisterPage RegPage;


        [SetUp]

        public void Initialized()
        {
            this.driver = BrowserHost.Instance.Application.Browser;
            this.RegPage = new RegisterPage(this.driver);
            RegPage.NavigateTo();
        }


        [TearDown]
        public void LogsandScreenshot()
        {
            TearDownClass TearLogs = new TearDownClass(this.driver);
            TearLogs.TearLogs();
        }


        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void NavigatetoRegisterPage()
        {         
             Assert.IsTrue(RegPage.RegisterButton.Displayed);
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void RegisterInvalidEmail()
        {
            var userex = AccessExcelData.GetTestData<RegisterPageUserModel>("RegisterPageData.xlsx", "DataSet", "InvalidEmail");
            RegPage.FillRegistrationForm(userex);
            RegPage.AssertErrorMessage("The Email field is not a valid e-mail address.");
          
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void RegisterWihtoutEmail()
        {
            var userex = AccessExcelData.GetTestData<RegisterPageUserModel>("RegisterPageData.xlsx", "DataSet", "Register without mail");
            RegPage.FillRegistrationForm(userex);
            RegPage.AssertErrorMessage("The Email field is required.");
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void RegisterAlreadyUsedEmail()
        {
            var userex = AccessExcelData.GetTestData<RegisterPageUserModel>("RegisterPageData.xlsx", "DataSet", "Register already used email");
            RegPage.FillRegistrationForm(userex);
            RegPage.AssertErrorMessage("The Email adress is already used");
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void RegisterWithoutFullName()
        {
            var userex = AccessExcelData.GetTestData<RegisterPageUserModel>("RegisterPageData.xlsx", "DataSet", "Register without FullName");
            RegPage.FillRegistrationForm(userex);
            RegPage.AssertErrorMessage("The Full Name field is required.");
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void RegisterWithoutPassword()
        {
            var userex = AccessExcelData.GetTestData<RegisterPageUserModel>("RegisterPageData.xlsx", "DataSet", "Register without Password");
            RegPage.FillRegistrationForm(userex);
            RegPage.AssertPasswordErrorMessage("The Password field is required.");
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void RegisterWithoutComfirmPassword()
        {
            var userex = AccessExcelData.GetTestData<RegisterPageUserModel>("RegisterPageData.xlsx", "DataSet", "Register without Confirm password");
            RegPage.FillRegistrationForm(userex);
            RegPage.AssertPasswordErrorMessage("The password and confirmation password do not match.");
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void PasswordDoNotMatch()
        {
            var userex = AccessExcelData.GetTestData<RegisterPageUserModel>("RegisterPageData.xlsx", "DataSet", "Passwords do not match");
            RegPage.FillRegistrationForm(userex);
            RegPage.AssertPasswordErrorMessage("The password and confirmation password do not match.");
        }
    }
}
