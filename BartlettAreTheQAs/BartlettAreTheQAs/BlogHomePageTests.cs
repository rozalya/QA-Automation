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
        private static SelenoHost host;
        [Test]
        public void NavigatetoBlog()
        {
            host = new SelenoHost();
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));           
            BlogHomePage home = new BlogHomePage(driver);
            home.NavigateTo();
            Assert.IsTrue(home.Logo.Displayed);
     //       driver.Quit();

        }

        [Test]
        public void  FirstArticleLoggedUserNo()
        {
            host = new SelenoHost();
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            BlogHomePage home = new BlogHomePage(driver);
            home.NavigateTo();
            home.FirstArticle.Click();
            IWebElement Text = driver.FindElement(By.XPath("/html/body/div[2]/div/article/header/h2"));
            Assert.IsTrue(Text.Displayed);
  //          driver.Quit();

        }

        [Test]
        public void FirstArticleClickOnEditLoggerUserNo()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            BlogHomePage home = new BlogHomePage(driver);
            home.NavigateTo();
            home.FirstArticle.Click();
            IWebElement EditButton = driver.FindElement(By.XPath("/html/body/div[2]/div/article/footer/a[1]"));
            EditButton.Click();
            IWebElement Login = driver.FindElement(By.XPath("/html/body/div[2]/div/div/h2"));
            Assert.IsTrue(Login.Displayed);


//            driver.Close();

        }

    }
}
