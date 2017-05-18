namespace BartlettAreTheQAs.Pages.AdminPage
{
    using NUnit.Framework;

    public static class AdminPageAsserter
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
