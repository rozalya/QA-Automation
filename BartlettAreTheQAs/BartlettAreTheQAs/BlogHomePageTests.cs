using BartlettAreTheQAs.Pages.HomePage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace BartlettAreTheQAs
{

    [TestFixture]
    class BlogHomePageTests
    {
        [Test]
        public void NavigatetoBlog()
        {

            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));           
            BlogHomePage home = new BlogHomePage(driver);
            home.NavigateTo();
            Assert.IsTrue(home.Logo.Displayed);
            driver.Close();

        }

        [Test]
        public void  FirstArticleLoggedUserNo()
        {
            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            BlogHomePage home = new BlogHomePage(driver);
            home.NavigateTo();
            home.FirstArticle.Click();
            IWebElement Text = driver.FindElement(By.XPath("/html/body/div[2]/div/article/header/h2"));
            Assert.IsTrue(Text.Displayed);
            driver.Close();

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


            driver.Close();

        }

    }
}
