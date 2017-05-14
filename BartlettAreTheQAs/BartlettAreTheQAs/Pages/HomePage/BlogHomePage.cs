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

    }
}
