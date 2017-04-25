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
    class ArtcileMainPageTests
    {
        [Test]
        public void NavigatetoBlog()
        {

            IWebDriver driver = BrowserHost.Instance.Application.Browser;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl("http://localhost:60634/Article/List");

            IWebElement logo = wait.Until(w => w.FindElement(By.XPath("html/body/div[1]/div/div[1]/a")));

      
            Assert.AreEqual("SOFTUNI BLOG", logo.Text);
             driver.Close();

        }
    }
}
