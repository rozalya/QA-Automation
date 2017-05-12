using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs.Pages.ManagePage
{
public static  class ManagePageAsserter
    {

        public static void AssertErrorMessage(this ManagePage page, string text)
        {
            Assert.AreEqual(text, page.EmailErrorMessage.Text);
        }


        public static void AssertPasswordErrorMessage(this ManagePage page, string text)
        {
            Assert.AreEqual(text, page.EmailErrorMessage.Text);
        }




    }
}
