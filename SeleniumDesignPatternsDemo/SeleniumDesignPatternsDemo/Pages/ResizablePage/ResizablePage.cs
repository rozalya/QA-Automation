using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternsDemo.Pages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        public ResizablePage(IWebDriver driver)
            :base(driver)
        {
        }
        public int width { get; set; }

        public int height { get; set; }

        public string URL
        {
            get
            {
                return base.url + "resizable/";
            }
        }
        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(URL);
        }

        public void IncreaseWidthAndheight(int increaseSizeW, int increaseSizeH)
        {
            this.NavigateTo();
            this.width = this.Resizable.Size.Width;
            this.height = this.Resizable.Size.Height;
            Actions builder = new Actions(this.Driver);
            var resize = builder.DragAndDropToOffset(this.Button, width + increaseSizeW, height + increaseSizeW);
            resize.Perform();
        }
       
    }
}
