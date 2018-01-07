using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternsDemo.Pages.RegistrationPage
{
    public static class RegistrationPageAsserter
    {
        public static void AssertRegistrationPageIsOpen(this RegistrationPage page, string text)
        {
            Assert.AreEqual(text, page.Header.Text);
        }

        public static void AssesrtSuccessMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.SuccessMessage.Displayed);
            Assert.AreEqual(text, page.SuccessMessage.Text);
        }

        public static void AssertNamesErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForNames.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForNames.Text);
        }
        public static void AssertNamesErrorMessageLastName(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForLastNames.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForLastNames.Text);
        }
        public static void AssertNamesErrorMessageNoUserName(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForNoUserName.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForNoUserName.Text);
        }
        public static void AssertErrorMessageInvaldeFile(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForInvalideFile.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForInvalideFile.Text);
        }
        public static void AssertErrorMessagePasswordMismatch(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForPasswordMismatch.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForPasswordMismatch.Text);
        }
        public static void AssertErrorMessageStrengthIndicatorMismatch(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForStrengthIndicatorMismatch.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForStrengthIndicatorMismatch.Text);
        }
        public static void AssertNamesErrorMessageDublicateEmail(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForDublicateEmail.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForDublicateEmail.Text);
        }
        public static void AssertShortPassErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForShortPass.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForShortPass.Text);
        }
        public static void AssertMessagesForNoEmail(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForNoEmail.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForNoEmail.Text);
        }
        public static void AssertMessagesForShortPhone(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForShortPhone.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForShortPhone.Text);
        }
        public static void AssertMessagesInvalideEmail(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForInvalideEmail.Displayed);
            StringAssert.Contains(text, page.ErrorMessageForInvalideEmail.Text);
        }
        public static void AssertMessagesDublicateUser(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesDublicateUser.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesDublicateUser.Text);
        }
        public static void AssertMessagesNoHobby(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForNoHobby.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForNoHobby.Text);
        }

        public static void AssertPhoneErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForPhone.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForPhone.Text);
        }
        public static void AssertPassErrorMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForPhone.Displayed);
            StringAssert.Contains(text, page.ErrorMessagesForPhone.Text);
        }
    }
}
