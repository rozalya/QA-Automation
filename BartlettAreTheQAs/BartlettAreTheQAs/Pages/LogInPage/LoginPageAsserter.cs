using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs.Pages.LogInPage
{
    public static class LogInPageAsserter
    {
        public static void AssertLogInPage(this LogInPage page, string text)
        {
            Assert.AreEqual(page.h2logInPage.Text, text);
        }
        public static void AssertLogInSuccessfully(this LogInPage page, string text)
        {
            Assert.AreEqual(page.LogOffBtn.Text,text);
        }
        public static void AssertMessageInvalidEmail(this LogInPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageInvalidEmail.Displayed);
            Assert.AreEqual( page.ErrorMessageInvalidEmail.Text, text);
        }
        public static void AssertMessageInvalidPass(this LogInPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageInvalidPassword.Displayed);
            Assert.AreEqual(page.ErrorMessageInvalidPassword.Text, text);
        }
        public static void AssertMessageWithoutEmail(this LogInPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageWithoutEmail.Displayed);
            Assert.AreEqual(page.ErrorMessageWithoutEmail.Text, text);
        }
        public static void AssertMessageWithoutPass(this LogInPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageWithoutPassword.Displayed);
            Assert.AreEqual(page.ErrorMessageWithoutPassword.Text, text);
        }
    }
}
