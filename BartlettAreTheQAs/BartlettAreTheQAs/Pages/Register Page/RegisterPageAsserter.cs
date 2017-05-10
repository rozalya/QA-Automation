using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs.Pages.Register_Page
{
public static  class RegisterPageAsserter
    {

        public static void AssertErrorMessage(this RegisterPage page, string text)
        {
            Assert.AreEqual(text, page.EmailErrorMessage.Text);
        }


        public static void AssertPasswordErrorMessage(this RegisterPage page, string text)
        {
            Assert.AreEqual(text, page.EmailErrorMessage.Text);
        }




    }
}
