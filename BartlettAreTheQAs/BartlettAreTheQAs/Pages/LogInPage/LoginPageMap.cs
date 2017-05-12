using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs.Pages.LogInPage
{
  public partial class LoginPage
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

        public IWebElement ChangePasswordButton
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/dl/dd/a")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/dl/dd/a"));


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
