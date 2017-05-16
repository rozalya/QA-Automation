using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using BartlettAreTheQAs.Models;

namespace BartlettAreTheQAs.Pages.LogInPage
{
    public partial class LogInPage : BasePage
    {
        public LogInPage(IWebDriver driver) : base(driver)
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
           // this.Driver.Navigate().GoToUrl("http://localhost:60634/Account/Login");
            this.Driver.Navigate().GoToUrl(this.URL);
            this.Driver.Manage().Window.Maximize();
        }


      

        public void FillLogInData(LogInUserModel userData)
        {
            if (userData.Email != null)
                this.LogInEmail.SendKeys(userData.Email);
            if (userData.Password != null)
                this.LogInPassword.SendKeys(userData.Password);
            if (userData.RememberMe == "1")
            {
                this.RememberMeCheckBox.Click();
            }
            this.LogInBtn.Click();
        }
    }
}
