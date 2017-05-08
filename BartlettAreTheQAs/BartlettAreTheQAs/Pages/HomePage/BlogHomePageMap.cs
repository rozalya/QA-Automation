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
        public IWebElement Logo
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("html/body/div[1]/div/div[1]/a")));
                return this.Driver.FindElement(By.XPath("html/body/div[1]/div/div[1]/a"));
              

            }
        }

        public IWebElement FirstArticle
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/article/header/h2/a")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/article/header/h2/a"));


            }
        }

    }
}
