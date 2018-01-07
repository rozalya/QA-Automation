using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternsDemo.Pages.DraggablePage
{
   public partial class DraggablePage
    {
        public IWebElement Container
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"tabs-1\"]/div"));
            }
        }
         public IWebElement Draggable
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggable"));
            }
        }
        public IWebElement DraggableText
        {
            get
            {
                 return this.Driver.FindElement(By.XPath("//*[@id=\"draggable\"]/p"));
            }
        }
    }
}
