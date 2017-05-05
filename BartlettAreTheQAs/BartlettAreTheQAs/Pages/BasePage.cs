using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs.Pages
{
  public  class BasePage
    {

        private IWebDriver driver = BrowserHost.Instance.Application.Browser;
        private WebDriverWait wait;
        //  protected String URL = ConfigurationManager.AppSettings["URL"];

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;

        }


        public IWebDriver Driver
        {
            get
            {
                return this.driver;
            }
        }
        public WebDriverWait Wait
        {
            get
            {
                return this.wait;
            }

        }

    }
}
