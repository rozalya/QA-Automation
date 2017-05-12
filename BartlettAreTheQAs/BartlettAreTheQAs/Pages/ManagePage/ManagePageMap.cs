using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs.Pages.ManagePage
{
  public partial class ManagePage
    {
        public IWebElement LoginButton
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/input")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/input"));


            }
        }
        
        public IWebElement ManageAccountButton
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[2]/a")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[2]/a"));


            }
        }
        
        public IWebElement PasswordChangeButton
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/dl/dd/a")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/dl/dd/a"));


            }
        }

        public IWebElement ConfirmPasswordChangeButton
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[5]/div/input")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[5]/div/input"));


            }
        }

        public IWebElement Email
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.Id("Email")));
                return this.Driver.FindElement(By.Id("Email"));

            }
        }

        public IWebElement Password
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.Id("Password")));
                return this.Driver.FindElement(By.Id("Password"));

            }
        }

        public IWebElement CurrentPassword
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.Id("OldPassword")));
                return this.Driver.FindElement(By.Id("OldPassword"));

            }
        }

        public IWebElement NewPassword
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.Id("NewPassword")));
                return this.Driver.FindElement(By.Id("NewPassword"));

            }
        }

        public IWebElement ConfirmPassword
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.Id("ConfirmPassword")));
                return this.Driver.FindElement(By.Id("ConfirmPassword"));

            }
        }

        public IWebElement PasswordSuccessChangeMessage
        {
            get
            {

                return this.Driver.FindElement(By.XPath("/html/body/div[2]/p"));

            }
        }


        public IWebElement FirstPasswordErrorMessage
        {
            get
            {

            return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li"));

            }
        }

        public IWebElement SecondPasswordErrorMessage
        {
            get
            {

                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[2]"));

            }
        }

        public IWebElement InvalidDataErrorMessage
        {
            get
            {

                return this.Driver.FindElement(By.XPath("/html/body/span/h2/i"));

            }
        }

        
    }
}
