using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternsDemo.Pages.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        public SelectablePage(IWebDriver driver)
            : base(driver)
        {
        }
        

        public string URL
        {
            get
            {
                return base.url + "selectable/";
            }
        }
        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(URL);
        }

    }
}
