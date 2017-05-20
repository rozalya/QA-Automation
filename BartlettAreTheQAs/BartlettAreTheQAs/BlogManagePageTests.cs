namespace BartlettAreTheQAs
{
    using BartlettAreTheQAs.Models;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using BartlettAreTheQAs.Attributes;
    using BartlettAreTheQAs.Pages.ManagePage;

    [TestFixture]
    class BlogManagePageTests
    {
        public IWebDriver driver;
        public ManagePage ManagePage;

        [SetUp]

        public void Initialized()
        {
            this.driver = BrowserHost.Instance.Application.Browser;
            this.ManagePage = new ManagePage(this.driver);
            ManagePage.NavigateTo();

        }

        [TearDown]
        public void LogsandScreenshot()
        {
            TearDownClass TearLogs = new TearDownClass(this.driver);
            TearLogs.TearLogs();
 
        }


        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void NavigateToManagePage()
        {
           
            var user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin");
            ManagePage.FillLoginForm(user);
           
            Assert.IsTrue(ManagePage.ManageAccountButton.Displayed);
           
            
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void NavigateToPasswordChange()
        {
            
            var user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin");
            ManagePage.FillLoginForm(user);
            ManagePage.ManageAccountButton.Click();
            Assert.IsTrue(ManagePage.PasswordChangeButton.Displayed);
            ManagePage.LogoutBtnAsUser.Click();
        }


        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void ValidPasswordChange()
        {
            
            var user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin");

            ManagePage.FillLoginForm(user);
            Assert.IsTrue(ManagePage.ManageAccountButton.Displayed);
            ManagePage.ManageAccountButton.Click();
            Assert.IsTrue(ManagePage.PasswordChangeButton.Displayed);
            ManagePage.PasswordChangeButton.Click();
            user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidPasswordChange");
            ManagePage.FillChangePasswordForm(user);
            ManagePage.AssertConfirmPasswordMessage("Your password has been changed.");
            //reverse password to previous one for other tests usage
            ManagePage.PasswordChangeButton.Click();
            user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidPasswordChangeReset");
            ManagePage.FillChangePasswordForm(user);
            ManagePage.LogoutBtnAsUser.Click();
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void PasswordChangeWithoutCurrentPassword()
        {
           
            var user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            ManagePage.FillLoginForm(user);
            //Assert.IsTrue(managePage.ManageAccountButton.Displayed);
            ManagePage.ManageAccountButton.Click();
            // Assert.IsTrue(managePage.PasswordChangeButton.Displayed);
            ManagePage.PasswordChangeButton.Click();
            user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "PasswordChangeWithoutCurrentPassword");
            ManagePage.FillChangePasswordForm(user);
            ManagePage.AssertFirstPasswordErrorMessage("The Current password field is required.");
            ManagePage.LogoutBtnAsUser.Click();
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void PasswordChangeWithWrongCurrentPassword()
        {
           
            var user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            ManagePage.FillLoginForm(user);
            //Assert.IsTrue(managePage.ManageAccountButton.Displayed);
            ManagePage.ManageAccountButton.Click();
            // Assert.IsTrue(managePage.PasswordChangeButton.Displayed);
            ManagePage.PasswordChangeButton.Click();
            user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "PasswordChangeWithWrongCurrentPassword");
            ManagePage.FillChangePasswordForm(user);
            ManagePage.AssertFirstPasswordErrorMessage("Incorrect password.");
            ManagePage.LogoutBtnAsUser.Click();
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void PasswordChangeWithoutNewPassword()
        {
            
            var user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            ManagePage.FillLoginForm(user);
            //Assert.IsTrue(managePage.ManageAccountButton.Displayed);
            ManagePage.ManageAccountButton.Click();
            // Assert.IsTrue(managePage.PasswordChangeButton.Displayed);
            ManagePage.PasswordChangeButton.Click();
            user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "PasswordChangeWithoutNewPassword");
            ManagePage.FillChangePasswordForm(user);
            ManagePage.AssertFirstPasswordErrorMessage("The New password field is required.");
            ManagePage.AssertSecondPasswordErrorMessage("The new password and confirmation password do not match.");
            ManagePage.LogoutBtnAsUser.Click();
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void PasswordChangeWithoutConfirmPassword()
        {
           
            var user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            ManagePage.FillLoginForm(user);
            //Assert.IsTrue(managePage.ManageAccountButton.Displayed);
            ManagePage.ManageAccountButton.Click();
            // Assert.IsTrue(managePage.PasswordChangeButton.Displayed);
            ManagePage.PasswordChangeButton.Click();
            user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "PasswordChangeWithoutConfirmPassword");
            ManagePage.FillChangePasswordForm(user);
            ManagePage.AssertFirstPasswordErrorMessage("The new password and confirmation password do not match.");
            ManagePage.LogoutBtnAsUser.Click();
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void PasswordChangeWithoutData()
        {
           
            var user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            ManagePage.FillLoginForm(user);
            //Assert.IsTrue(managePage.ManageAccountButton.Displayed);
            ManagePage.ManageAccountButton.Click();
            // Assert.IsTrue(managePage.PasswordChangeButton.Displayed);
            ManagePage.PasswordChangeButton.Click();
            user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "PasswordChangeWithoutData");
            ManagePage.FillChangePasswordForm(user);
            ManagePage.AssertFirstPasswordErrorMessage("The Current password field is required.");
            ManagePage.AssertSecondPasswordErrorMessage("The New password field is required.");
            ManagePage.LogoutBtnAsUser.Click();
        }

        //must fail
        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void PasswordChangeWithInvalidSymbols()
        {
            
            var user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            ManagePage.FillLoginForm(user);
            //Assert.IsTrue(managePage.ManageAccountButton.Displayed);
            ManagePage.ManageAccountButton.Click();
            // Assert.IsTrue(managePage.PasswordChangeButton.Displayed);
            ManagePage.PasswordChangeButton.Click();
            user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "PasswordChangeWithInvalidSymbols");
            ManagePage.FillChangePasswordForm(user);
            //Origanl Aseert 
            Assert.AreEqual("A potentially dangerous Request.Form value was detected from the client (NewPassword=\"</\").", ManagePage.InvalidDataErrorMessage.Text);
        }
    }


   
}
