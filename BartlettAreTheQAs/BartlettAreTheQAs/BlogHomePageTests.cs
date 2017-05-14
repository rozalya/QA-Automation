using BartlettAreTheQAs.Attributes;
using BartlettAreTheQAs.Pages.HomePage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
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
        [TearDown]
        public void LogsandScreenshot()
        {
            TearDownClass TearLogs = new TearDownClass();
            TearLogs.TearLogs();
        }


        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void NavigatetoBlog()
        {         
            BlogHomePage home = new BlogHomePage();
            home.NavigateTo();
            Assert.IsTrue(home.Logo.Displayed);
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void  GoInFirstArticleLoggedUserNo()
        {
            BlogHomePage home = new BlogHomePage();
            home.NavigateTo();
            home.FirstArticle.Click();
            IWebElement Text = home.Driver.FindElement(By.XPath("/html/body/div[2]/div/article/header/h2"));
            Assert.IsTrue(Text.Displayed);
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void FirstArticleClickOnEditBtnLoggerUserNo()
        {
            BlogHomePage home = new BlogHomePage();
            home.NavigateTo();
            home.FirstArticle.Click();
            IWebElement EditButton = home.Driver.FindElement(By.XPath("/html/body/div[2]/div/article/footer/a[1]"));
            EditButton.Click();
            IWebElement Login = home.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/h2"));
            Assert.IsTrue(Login.Displayed);
        }

    }
}
