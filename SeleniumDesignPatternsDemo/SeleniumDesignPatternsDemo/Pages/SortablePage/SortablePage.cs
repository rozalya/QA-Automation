using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternsDemo.Pages.SortablePage
{
    public partial class SortablePage : BasePage
    {
        public SortablePage(IWebDriver driver)
            : base(driver)
        {
        }


        public string URL
        {
            get
            {
                return base.url + "sortable/";
            }
        }
        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(URL);
        }

        public void MoveElement()
        {
            this.NavigateTo();
            Actions builder = new Actions(this.Driver);
           
            var sortable = builder.DragAndDropToOffset (Item1, 100, 100);

            sortable.Perform();
        }

        public void MoveElemenUp()
        {
            this.NavigateTo();
            Actions builder = new Actions(this.Driver);
            // var sortable = builder.DragAndDrop(Item1, Item3);
            //var sortable = builder.DragAndDropToOffset(Item3, 200, 200);
            var sortable = builder.MoveToElement(Item3).ClickAndHold().MoveToElement(Item1).Release();
            sortable.Perform();
        }


    }
}

