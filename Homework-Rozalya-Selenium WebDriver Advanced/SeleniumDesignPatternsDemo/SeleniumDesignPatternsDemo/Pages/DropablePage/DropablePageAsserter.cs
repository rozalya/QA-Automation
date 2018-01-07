using NUnit.Framework;
using SeleniumDesignPatternsDemo.Pages.DropablePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternsDemo.Pages.DropablePage
{
    public static class DropablePageAsserter
    {
        public static void AssertTargetAttributeValue(this DropablePage page, string classValue)
        {
            Assert.AreEqual(classValue, page.Drop.GetAttribute("class"));
        }
        public static void AssertTargetAttributeText(this DropablePage page, string classValue)
        {
            Assert.AreEqual(classValue, page.Drop.Text);
        }

        public static void AssertDisplayElementsDrop(this DropablePage page)
        {
            Assert.IsTrue(page.Drop.Displayed);

        }
        public static void AssertDisplayElementsDrag(this DropablePage page)
        {
            Assert.IsTrue(page.Drag.Displayed);

        }
        public static void AssertNewPosition(this DropablePage page, int pixelToLeft, int pixelToTop)
        {
            Assert.IsTrue(page.Left > 68 && page.Top >100);

        }
    }
}
