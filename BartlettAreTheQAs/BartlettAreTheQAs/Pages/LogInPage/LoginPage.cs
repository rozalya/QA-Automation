using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using BartlettAreTheQAs.Models;

namespace BartlettAreTheQAs.Pages.LogInPage
{
    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public String URL
        {
            get
            {
                return base.URL + "Account/Login/";
            }

        }


        public void NavigateTo()
        {
           
            this.Driver.Navigate().GoToUrl(this.URL);
            this.Driver.Manage().Window.Maximize();

        }


        public void FillLoginForm(RegisterPageUserModel user)
        {
            Type(this.Email, user.Email);          
            Type(this.Password, user.Password);
            this.LoginButton.Click();


        }


        private void Type(IWebElement element, string text)
        {
            if (text == null)
            {
                element.Clear();
            }
            else
            {
                element.Clear();
                element.SendKeys(text);
            }


        }



    }
}
