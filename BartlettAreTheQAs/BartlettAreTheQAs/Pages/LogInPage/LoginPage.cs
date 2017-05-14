﻿using System;
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
        public LogInPage() : base()
        {
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://localhost:60634/Account/Login");
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
