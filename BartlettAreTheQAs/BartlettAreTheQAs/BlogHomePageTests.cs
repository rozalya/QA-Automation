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
    }
}
