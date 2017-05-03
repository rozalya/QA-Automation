using BartlettAreTheQAs.Pages.HomePage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.BrowserStack.Core.Configuration;

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
            home.Navigate();
            Assert.IsTrue(home.Logo.Displayed);
            driver.Close();

        }
    }
}
