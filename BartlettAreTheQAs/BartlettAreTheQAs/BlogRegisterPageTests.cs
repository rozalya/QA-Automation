using BartlettAreTheQAs.Pages.Register_Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs
{
    [TestFixture]
    class BlogRegisterPageTests
    {
        [Test]
        public void NavigatetoResiterPage()
        {

             IWebDriver driver = BrowserHost.Instance.Application.Browser;
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
             RegisterPage RegPage = new RegisterPage(driver);
             RegPage.NavigateTo();
             Assert.IsTrue(RegPage.RegisterButton.Displayed);
             driver.Close();

        }

    }
}
