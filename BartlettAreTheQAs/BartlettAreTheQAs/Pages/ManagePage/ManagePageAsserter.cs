namespace BartlettAreTheQAs.Pages.ManagePage
{
    using NUnit.Framework;

    public static class ManagePageAsserter
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
