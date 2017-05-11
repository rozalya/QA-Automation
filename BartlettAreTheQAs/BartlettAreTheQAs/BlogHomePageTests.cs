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
        public IWebDriver driver;        
        [SetUp]
     
        public void Initialized()
        {
            this.driver = BrowserHost.Instance.Application.Browser;
        }

        [TearDown]
        public void LogsandScreenshot()
        {


            string filename = ConfigurationManager.AppSettings["Logs"] + TestContext.CurrentContext.Test.Name + ".txt";
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            File.WriteAllText(filename, TestContext.CurrentContext.Test.FullName + "        "
                + TestContext.CurrentContext.WorkDirectory + "            "
                + TestContext.CurrentContext.Result.PassCount);

            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                var screenshot = ((ITakesScreenshot)this.driver).GetScreenshot();
                screenshot.SaveAsFile(filename + TestContext.CurrentContext.Test.Name + ".jpg", ScreenshotImageFormat.Jpeg);
            }

            // Don't close the driver because of TeamCity  
            //  driver.Close();

        }


        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void NavigatetoBlog()
        {         
            BlogHomePage home = new BlogHomePage(this.driver);
            home.NavigateTo();
            Assert.IsTrue(home.Logo.Displayed);
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void  GoInFirstArticleLoggedUserNo()
        {
            BlogHomePage home = new BlogHomePage(this.driver);
            home.NavigateTo();
            home.FirstArticle.Click();
            IWebElement Text = driver.FindElement(By.XPath("/html/body/div[2]/div/article/header/h2"));
            Assert.IsTrue(Text.Displayed);
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void FirstArticleClickOnEditBtnLoggerUserNo()
        {
            BlogHomePage home = new BlogHomePage(this.driver);
            home.NavigateTo();
            home.FirstArticle.Click();
            IWebElement EditButton = driver.FindElement(By.XPath("/html/body/div[2]/div/article/footer/a[1]"));
            EditButton.Click();
            IWebElement Login = driver.FindElement(By.XPath("/html/body/div[2]/div/div/h2"));
            Assert.IsTrue(Login.Displayed);
        }

    }
}
