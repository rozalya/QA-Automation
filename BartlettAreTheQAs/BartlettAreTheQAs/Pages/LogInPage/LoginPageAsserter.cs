using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs.Pages.LogInPage
{
public static  class LoginPageAsserter
    {

        public static void AssertErrorMessage(this LoginPage page, string text)
        {
            Assert.AreEqual(text, page.EmailErrorMessage.Text);
        }


        public static void AssertPasswordErrorMessage(this LoginPage page, string text)
        {
            Assert.AreEqual(text, page.EmailErrorMessage.Text);
        }




    }
}
