using BartlettAreTheQAs.Pages.HomePage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TestStack.Seleno.Configuration;

namespace BartlettAreTheQAs
{

    [TestFixture]
    class BlogHomePageTests
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
        public void NavigatetoBlog()
        {         
            BlogHomePage home = new BlogHomePage(driver);
            home.NavigateTo();
            Assert.IsTrue(home.Logo.Displayed);
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void  GoInFirstArticleLoggedUserNo()
        {
            BlogHomePage home = new BlogHomePage(driver);
            home.NavigateTo();
            home.FirstArticle.Click();
            IWebElement Text = driver.FindElement(By.XPath("/html/body/div[2]/div/article/header/h2"));
            Assert.IsTrue(Text.Displayed);
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void FirstArticleClickOnEditBtnLoggerUserNo()
        {
            BlogHomePage home = new BlogHomePage(driver);
            home.NavigateTo();
            home.FirstArticle.Click();
            IWebElement EditButton = driver.FindElement(By.XPath("/html/body/div[2]/div/article/footer/a[1]"));
            EditButton.Click();
            IWebElement Login = driver.FindElement(By.XPath("/html/body/div[2]/div/div/h2"));
            Assert.IsTrue(Login.Displayed);
        }

    }
}
