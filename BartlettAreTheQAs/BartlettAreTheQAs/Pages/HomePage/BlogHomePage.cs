using BartlettAreTheQAs.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs.Pages.HomePage
{
    public partial class BlogHomePage : BasePage
    {
        public BlogHomePage() : base()
        {

        }

        public String URL
        {
            get
            {
                return base.URL + "Article/List/";
            }

        }


        public void NavigateTo()
        {
            
            this.Driver.Navigate().GoToUrl(this.URL);
            this.Driver.Manage().Window.Maximize();
        }
       public void FillLogOn(HomePageLogInUserModel user)
        {
            Type(this.Email, user.Email);
            Type(this.Password, user.Password);
            this.LogInBtn.Click();
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
