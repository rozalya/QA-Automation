using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternsDemo.Pages.SortablePage
{
    public static class SortablePageAsserter
    {
        public static void AssertDisplaySortElement(this SortablePage page)
        {
            Assert.IsTrue(page.Item1.Displayed);

        }
        public static void AssertMoveSortElement(this SortablePage page, string text)
        {
            Assert.AreEqual(text, page.Item1.Text);

        }
    }
}
