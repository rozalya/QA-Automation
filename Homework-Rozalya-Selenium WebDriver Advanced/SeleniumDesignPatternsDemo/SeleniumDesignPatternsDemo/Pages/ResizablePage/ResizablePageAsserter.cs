using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternsDemo.Pages.ResizablePage
{
    public static class ResizablePageAsserter
    {
        public static void AssertDisplayResizeElement(this ResizablePage page)
        {
            Assert.IsTrue(page.Resizable.Displayed);

        }

        public static void AssertNewSizeWidth(this ResizablePage page, int pixelWidth)
        {
            Assert.IsTrue(page.Resizable.Size.Width > 150);

        }

        public static void AssertNewSizeHeight(this ResizablePage page, int pixelHeight)
        {
            Assert.IsTrue(page.Resizable.Size.Height > 150);

        }
    }
}
