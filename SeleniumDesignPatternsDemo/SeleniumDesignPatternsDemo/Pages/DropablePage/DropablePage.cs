using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternsDemo.Pages.DropablePage
{
    public partial class DropablePage : BasePage
    {
        public DropablePage(IWebDriver driver)
            :base(driver)
        {
        }
        public int Left { get; set; }

        public int Top { get; set; }

        public string URL
        {
            get
            {
                return base.url + "droppable/";
            }
        }
        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(URL);
        }
          public void DragAndDrop()
        {
            this.Driver.Url = "http://demoqa.com/droppable/";
            Actions builder = new Actions(this.Driver);
            var drag = builder.DragAndDrop(this.Drag, this.Drop);
            drag.Perform();
        }

        public void DragAndDropOnBorder(int moveLeft, int moveTop)
        {
            this.Driver.Url = "http://demoqa.com/droppable/";
            Actions builder = new Actions(this.Driver);
            var dragElem = builder.MoveToElement(Drag).ClickAndHold();
            dragElem.MoveByOffset(70, 105);
            dragElem.Perform();
        }


    }
}
