using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternsDemo.Pages.ResizablePage
{
    public partial class ResizablePage
    {
        
          public IWebElement Resizable
        {
            get
            {
                return this.Driver.FindElement(By.Id("resizable"));
            }
        }

      
        public IWebElement Button {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"resizable\"]/div[3]"));
            } }
    }
}
