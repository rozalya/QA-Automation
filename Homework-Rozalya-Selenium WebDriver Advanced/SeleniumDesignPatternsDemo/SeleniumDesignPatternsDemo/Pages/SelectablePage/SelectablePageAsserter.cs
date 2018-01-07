using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternsDemo.Pages.SelectablePage
{
    public static class SelectablePageAsserter
    {
        public static void AssertDisplaySelectElement(this SelectablePage page)
        {
            Assert.IsTrue(page.Item1.Displayed);

        }
        public static void AssertSelectedElement(this SelectablePage page, string Value)
        {
            Assert.AreEqual(Value, page.Item1.GetAttribute("class"));

        }
        public static void AssertSelectedLestElement(this SelectablePage page, string Value)
        {
            Assert.AreEqual(Value, page.Item7.GetAttribute("class"));

        }
    }
}
