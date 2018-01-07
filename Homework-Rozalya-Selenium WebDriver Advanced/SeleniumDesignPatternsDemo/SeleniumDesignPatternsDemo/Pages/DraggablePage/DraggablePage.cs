using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternsDemo.Pages.DraggablePage
{
   public partial class DraggablePage : BasePage
    {
        public DraggablePage(IWebDriver driver)
            :base(driver)
        {
        }
        public int Left { get; set; }

        public int Top { get; set; }
        public string URL
        {
            get
            {
                return base.url + "draggable/";
            }
        }
        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(URL);
        }
        //public void DragAndDrop()
        //{
        //    this.Driver.Url = "http://demoqa.com/draggable/";
        //    Actions builder = new Actions(this.Driver);
        //    var drag = builder.DragAndDrop(this.Container, this.Draggable);
        //    drag.Perform();
        //}

        public  void ChangePosition (int moveLeft, int moveTop)
        {
            this.NavigateTo();
            this.Left = this.Draggable.Location.X;
            this.Top = this.Draggable.Location.Y;
            Actions builder = new Actions(this.Driver);
            var resize = builder.DragAndDropToOffset(this.Draggable, moveLeft, moveTop);
            resize.Perform();
        }
    }
}
