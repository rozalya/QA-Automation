using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs.Pages.Register_Page
{
  public partial  class RegisterPage
    {
        public IWebElement RegisterButton
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/input")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/input"));


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


        public IWebElement FullName
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.Id("FullName")));
                return this.Driver.FindElement(By.Id("FullName"));

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

        public IWebElement ConfirmPassword
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.Id("ConfirmPassword")));
                return this.Driver.FindElement(By.Id("ConfirmPassword"));

            }
        }


        public IWebElement EmailErrorMessage
        {
            get
            {

            //    this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li"));

            }
        }



        public IWebElement PasswordErrorMessage
        {
            get
            {

                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[1]"));

            }
        }

    }
}
