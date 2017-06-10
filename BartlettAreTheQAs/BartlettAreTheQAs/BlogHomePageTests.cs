using BartlettAreTheQAs.Attributes;
using BartlettAreTheQAs.Models;
using BartlettAreTheQAs.Pages.HomePage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using System.IO;
using TestStack.Seleno.Configuration;

namespace BartlettAreTheQAs
{

    [TestFixture]
    class BlogHomePageTests
    {
        public IWebDriver driver;
        public BlogHomePage home;

        [SetUp]

        public void Initialized()
        {
            this.driver = BrowserHost.Instance.Application.Browser;
            this.home = new BlogHomePage(this.driver);
            home.NavigateTo();
        }

        [TearDown]
        public void LogsandScreenshot()
        {
           TearDownClass TearLogs = new TearDownClass(this.driver);
           TearLogs.TearLogs();
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void NavigatetoBlog()
        {               
            Assert.IsTrue(home.Logo.Displayed);
        }

      //  [Test, Property("Priority", 2)]
     //   [Author("Nataliya Zh")]
    //   public void  GoInFirstArticleLoggedUserNo()
     //   {
        //    home.FirstArticle.Click();         
      //      Assert.IsTrue(home.FirstArticleTitle.Displayed);
      //  }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void FirstArticleClickOnEditBtnLoggerUserNo()
        {
                home.GototheFirstArctileClickOnEdit();
                Assert.IsTrue( this.driver.Url.Contains("http://localhost:60634/Account/Login"));
        }

        [Test, Property("Priority", 1)]
        [Author("Rozaliya Evtimova")]
        public void HoverOnLogo()
        {
            Actions builder = new Actions(this.driver);
            builder.MoveToElement(home.Logo).Perform();
            home.HoverOnLogo("rgba(24, 188, 156, 1)");
        }

        [Test, Property("Priority", 1)]
        [Author("Rozaliya Evtimova")]
        public void HoverOnArticle()
        {

            Actions builder = new Actions(this.driver);
            builder.MoveToElement(home.FirstArticle).Perform();
            home.HoverOnFirstArtilce("underline solid rgb(24, 188, 156)");
        }

        [Test, Property("Priority", 1)]
        [Author("Rozaliya Evtimova")]
        public void FirstArticleText()
        {
            home.FirstArticleText();
        }

        [Test, Property("Priority", 1)]
        [Author("Rozaliya Evtimova")]
        public void FirstArticleAutor()
        {
            home.FirstArticleAutor();
        }

        [Test, Property("Priority", 2)]
        [Author("Rozaliya Evtimova")]
        public void RegisterDisplayNoLogInUser()
        {
          home.RegisterLinkDisplayed();           
        }

        [Test, Property("Priority", 2)]
        [Author("Rozaliya Evtimova")]
        public void LogInDisplayNoLogInUser()
        {
            home.LonInLinkDisplayed();
        }

        [Test, Property("Priority", 1)]
        [Author("Rozaliya Evtimova")]
        public void HoverOnRegisterLink()
        {
            Actions builder = new Actions(this.driver);
            builder.MoveToElement(home.RegisterLink).Perform();
            home.HoverOnRegisterLink("rgba(24, 188, 156, 1)");
        }

        [Test, Property("Priority", 1)]
        [Author("Rozaliya Evtimova")]
        public void HoverOnLogInLink()
        {
            Actions builder = new Actions(this.driver);
            builder.MoveToElement(home.LoginLink).Perform();
            home.HoverOnLogInLink("rgba(24, 188, 156, 1)");
        }

        [Test, Property("Priority", 2)]
        [Author("Rozaliya Evtimova")]
        public void ClickOnLoginLink()
        {
            home.LoginLink.Click();  
        }



        [Test, Property("Priority", 2)]
        [Author("Rozaliya Evtimova")]
        public void ClickOnRegisterLink()
        {

            home.RegisterLink.Click();
            home.RegisterLinkClick();
        }

        [Test, Property("Priority", 2)]
        [Author("Rozaliya Evtimova")]
        public void LogInUserHelloElement()
        {
            home.LoginLink.Click();
            var user = AccessExcelData.GetTestData<HomePageLogInUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            home.FillLogOn(user);
            home.LogInHelloDiplay();
            home.LogOff.Click();

        }

        [Test, Property("Priority", 2)]
        [Author("Rozaliya Evtimova")]
        public void LogInUserHelloElementClick()
        {
            home.LoginLink.Click();
            var user = AccessExcelData.GetTestData<HomePageLogInUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            home.FillLogOn(user);
            home.Hello.Click();
            home.LogInManageDisplay();
            home.LogOff.Click();

        }

        [Test, Property("Priority", 2)]
        [Author("Rozaliya Evtimova")]
        public void LogInUserCreateLink()
        {
            home.LoginLink.Click();
            var user = AccessExcelData.GetTestData<HomePageLogInUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            home.FillLogOn(user);
            home.CreateLinkDispleyd();
            home.LogOff.Click();

        }

        [Test, Property("Priority", 2)]
        [Author("Rozaliya Evtimova")]
        public void LogInUserCreateLinkClick()
        {
            home.LoginLink.Click();
            var user = AccessExcelData.GetTestData<HomePageLogInUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            home.FillLogOn(user);
            home.CreateLink.Click();
            home.CreateNamePageDisplayed();
            home.LogOff.Click();

        }

        [Test, Property("Priority", 2)]
        [Author("Rozaliya Evtimova")]
        public void LogInUserBackToHomePageFromCreate()
        {
            home.LoginLink.Click();
            var user = AccessExcelData.GetTestData<HomePageLogInUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            home.FillLogOn(user);
            home.CreateLink.Click();
            home.Logo.Click();
            home.FirstArticleText();
            home.LogOff.Click();

        }

        [Test, Property("Priority", 2)]
        [Author("Rozaliya Evtimova")]
        public void LogInUserBClickOnArticle()
        {
            home.LoginLink.Click();
            var user = AccessExcelData.GetTestData<HomePageLogInUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            home.FillLogOn(user);
            home.FirstArticle.Click();
            home.FirstArtileTitleDisplayed();
            home.LogOff.Click();

        }
        [Test, Property("Priority", 2)]
        [Author("Rozaliya Evtimova")]
        public void LogOffLink()
        {
            home.LoginLink.Click();
            var user = AccessExcelData.GetTestData<HomePageLogInUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            home.FillLogOn(user);
            home.LogOffDisplayed();
            home.LogOff.Click();

        }
    }
}
