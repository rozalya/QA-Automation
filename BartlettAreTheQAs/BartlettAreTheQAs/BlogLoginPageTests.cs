using BartlettAreTheQAs.Models;
using BartlettAreTheQAs.Pages.LogInPage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BartlettAreTheQAs
{
    public class BlogLoginPageTests
    {
        private LogInPage logInPage;

        [SetUp]
        public void TestSetUp()
        {
            this.logInPage = new LogInPage();
            logInPage.NavigateTo();
        }

        [TearDown]
        public void CleanUp()
        {
            //logInPage.Driver.Quit();
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void NavigateToLogInPage()
        {
            this.logInPage.AssertLogInPage("Log in");
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void LoginSuccessfully()
        {
            LogInUserModel user = AccessExcelData.GetTestData<LogInUserModel>("LogInPageData.xlsx", "LogInUserData", "LogInSuccessfully");
            logInPage.FillLogInData(user);
            this.logInPage.AssertLogInSuccessfully("Log off");
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void LogInWithWrongEmail()
        {
            LogInUserModel user = AccessExcelData.GetTestData<LogInUserModel>("LogInPageData.xlsx", "LogInUserData", "LogInWithWrongEmail");
            logInPage.FillLogInData(user);
            this.logInPage.AssertMessageInvalidEmail("The Email field is not a valid e-mail address.");
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void LogInWithWrongPassword()
        {
            LogInUserModel user = AccessExcelData.GetTestData<LogInUserModel>("LogInPageData.xlsx", "LogInUserData", "LogInWithWrongPass");
            logInPage.FillLogInData(user);
            this.logInPage.AssertMessageInvalidPass("Invalid login attempt.");
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void LogInWithoutgData()
        {
            logInPage.LogInBtn.Click();
            this.logInPage.AssertMessageWithoutEmail("The Email field is required.");
            this.logInPage.AssertMessageWithoutPass("The Password field is required.");
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void LogInWithoutEmail()
        {
            LogInUserModel user = AccessExcelData.GetTestData<LogInUserModel>("LogInPageData.xlsx", "LogInUserData", "LogInWithoutEmail");
            logInPage.FillLogInData(user);
            this.logInPage.AssertMessageWithoutEmail("The Email field is required.");
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void LogInWithoutPass()
        {
            LogInUserModel user = AccessExcelData.GetTestData<LogInUserModel>("LogInPageData.xlsx", "LogInUserData", "LogInWithoutPass");
            logInPage.FillLogInData(user);
            this.logInPage.AssertMessageWithoutPass("The Password field is required.");
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void LogInRemeberMe()
        {
            LogInUserModel user = AccessExcelData.GetTestData<LogInUserModel>("LogInPageData.xlsx", "LogInUserData", "LogInWithCheckBox");
            logInPage.FillLogInData(user);
            this.logInPage.AssertLogInSuccessfully("Log off");

            this.logInPage.Driver.Navigate().GoToUrl("https://google.com");
            this.logInPage.NavigateTo();
            this.logInPage.AssertLogInSuccessfully("Log off");
        }
    }
}
