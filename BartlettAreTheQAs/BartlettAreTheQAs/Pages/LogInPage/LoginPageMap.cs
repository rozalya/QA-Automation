using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BartlettAreTheQAs.Pages.LogInPage
{
    public partial class LogInPage
    {

        public IWebElement LogInBtn
        {
            get
            {
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/input"));
               
            }
        }

        public IWebElement LogInEmail
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"Email\"]"));
            }
        }
        public IWebElement LogInPassword
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"Password\"]"));
            }
        }

        public IWebElement RememberMeCheckBox
        {
            get
            {
                return this.Driver.FindElement(By.Id("RememberMe"));
            }
        }
        public IWebElement h2logInPage
        {
            get
            {
                return this.Driver.FindElement(By.XPath("html/body/div[2]/div/div/h2"));
            }
        }
        public IWebElement LogOffBtn
        {
            get
            {
                
                return this.Driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[3]/a"));
            }
        }
        public IWebElement ErrorMessageInvalidEmail
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/div/span/span")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/div/span/span"));
            }
        }
        public IWebElement ErrorMessageInvalidPassword
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li"));
            }
        }
        public IWebElement ErrorMessageWithoutEmail
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("html/body/div[2]/div/div/form/div[1]/div/span/span")));
                return this.Driver.FindElement(By.XPath("html/body/div[2]/div/div/form/div[1]/div/span/span"));
            }
        }
        public IWebElement ErrorMessageWithoutPassword
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div[2]/div/div/form/div[2]/div/span/span")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[2]/div/span/span"));
            }
        }
    }
}
