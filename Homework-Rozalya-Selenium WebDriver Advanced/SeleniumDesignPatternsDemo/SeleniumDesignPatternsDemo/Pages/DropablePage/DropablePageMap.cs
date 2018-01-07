using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternsDemo.Pages.DropablePage
{
    public partial class DropablePage
    {
        public IWebElement Drag
        {
            get
            {
                return this.Driver.FindElement(By.Id("draggableview"));
            }
        }
        public IWebElement Drop
        {
            get
            {
                return this.Driver.FindElement(By.Id("droppableview"));
            }
        }
    }
}
