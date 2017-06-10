using BartlettAreTheQAs.Attributes;
using BartlettAreTheQAs.Models;
using BartlettAreTheQAs.Pages.HomePage;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs
{
    [TestFixture]
    class BlogHomePageLoggedUser
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
            home.LogOff.Click();
        }


        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void EditNotOwnedArticle()
        {
               
            home.LogInwithNotOwner();
            home.GototheFirstArctileClickOnEdit();         
            home.RegisterURL();

        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void DeleteNotOwnedArticle()
        {
           
            home.LogInwithNotOwner();
            home.GototheFirstArctileClickOnDelete();
            home.RegisterURL();
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void BackFromArticleLoggedUser()
        {           
            home.LogInwithNotOwner();          
            home.GototheFirstArctileClickOnBack();
            Assert.IsTrue(home.Hello.Displayed);
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void CreateArticleByTestUser()
        {
            home.LogInwithTestOwnerForCreationDeletion();
            home.CreateArticle();
            // Test is not ready Asset needed
        }

    }
}
