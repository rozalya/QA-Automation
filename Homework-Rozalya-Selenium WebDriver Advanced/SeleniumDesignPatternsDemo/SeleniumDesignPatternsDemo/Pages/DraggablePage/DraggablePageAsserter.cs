using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumDesignPatternsDemo.Pages.DraggablePage
{
    public static class DraggablePageAsserter
    {
        public static void AssertDisplayElement(this DraggablePage page)
        {
            Assert.IsTrue(page.Draggable.Displayed);
           
        }
        public static void AssertNewPositionLeft(this DraggablePage page, int pixelToLeft)
        {
            Assert.IsTrue(page.Left > 6);
           
        }
        public static void AssertNewPositionTop(this DraggablePage page, int pixelToLeft)
        {
           
            Assert.IsTrue(page.Top > 100);
        }
        public static void AssertElementText(this DraggablePage page, string text)
        {
            Assert.AreEqual(text, page.Draggable.Text);
        }
    }
}
