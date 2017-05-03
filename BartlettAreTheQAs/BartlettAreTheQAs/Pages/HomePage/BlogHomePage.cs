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
        public BlogHomePage(IWebDriver driver) : base(driver)
        {

        }
        public void Navigate()
        {
            this.Driver.Navigate().GoToUrl("http://localhost:60634/Article/List");
        }

    }
}
