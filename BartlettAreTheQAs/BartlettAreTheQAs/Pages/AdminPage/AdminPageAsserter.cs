using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs.Pages.AdminPage
{
public static  class AdminPageAsserter
    {

        public static void AssertErrorMessage(this AdminPage page, string text)
        {
            Assert.AreEqual(text, page.PasswordErrorMessage.Text);
        }


        public static void AssertConfirmMessage(this AdminPage page, string text)
        {
            Assert.AreEqual(text, page.SuccessChangeMessage.Text);
        }

    }
}
