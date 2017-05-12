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

        public static void AssertFirstPasswordErrorMessage(this ManagePage page, string text)
        {
            Assert.AreEqual(text, page.FirstPasswordErrorMessage.Text);
        }


        public static void AssertConfirmPasswordMessage(this ManagePage page, string text)
        {
            Assert.AreEqual(text, page.PasswordSuccessChangeMessage.Text);
        }

        public static void AssertSecondPasswordErrorMessage(this ManagePage page, string text)
        {
            Assert.AreEqual(text, page.SecondPasswordErrorMessage.Text);
        }


    }
}
