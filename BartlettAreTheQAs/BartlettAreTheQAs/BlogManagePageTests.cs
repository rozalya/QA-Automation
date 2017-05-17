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

        [SetUp]

        public void Initialized()
        {
            this.driver = BrowserHost.Instance.Application.Browser;
      

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
            ManagePage managePage = new ManagePage(this.driver);
            managePage.NavigateTo();
            var user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin");
            managePage.FillLoginForm(user);
           
            Assert.IsTrue(managePage.ManageAccountButton.Displayed);
            
            
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void NavigateToPasswordChange()
        {
            ManagePage managePage = new ManagePage(this.driver);
            managePage.NavigateTo();
            var user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin");
            managePage.FillLoginForm(user);
            managePage.ManageAccountButton.Click();
            Assert.IsTrue(managePage.PasswordChangeButton.Displayed);
            
        }


        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void ValidPasswordChange()
        {
            ManagePage managePage = new ManagePage(this.driver);
            managePage.NavigateTo();
            var user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin");

            managePage.FillLoginForm(user);
            Assert.IsTrue(managePage.ManageAccountButton.Displayed);
            managePage.ManageAccountButton.Click();
            Assert.IsTrue(managePage.PasswordChangeButton.Displayed);
            managePage.PasswordChangeButton.Click();
            user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidPasswordChange");
            managePage.FillChangePasswordForm(user);
            managePage.AssertConfirmPasswordMessage("Your password has been changed.");
            //reverse password to previous one for other tests usage
            managePage.PasswordChangeButton.Click();
            user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidPasswordChangeReset");
            managePage.FillChangePasswordForm(user);
          
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void PasswordChangeWithoutCurrentPassword()
        {
            ManagePage managePage = new ManagePage(this.driver);
            managePage.NavigateTo();
            var user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            managePage.FillLoginForm(user);
            //Assert.IsTrue(managePage.ManageAccountButton.Displayed);
            managePage.ManageAccountButton.Click();
           // Assert.IsTrue(managePage.PasswordChangeButton.Displayed);
            managePage.PasswordChangeButton.Click();
            user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "PasswordChangeWithoutCurrentPassword");
            managePage.FillChangePasswordForm(user);
            managePage.AssertFirstPasswordErrorMessage("The Current password field is required.");
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void PasswordChangeWithWrongCurrentPassword()
        {
            ManagePage managePage = new ManagePage(this.driver);
            managePage.NavigateTo();
            var user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            managePage.FillLoginForm(user);
            //Assert.IsTrue(managePage.ManageAccountButton.Displayed);
            managePage.ManageAccountButton.Click();
            // Assert.IsTrue(managePage.PasswordChangeButton.Displayed);
            managePage.PasswordChangeButton.Click();
            user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "PasswordChangeWithWrongCurrentPassword");
            managePage.FillChangePasswordForm(user);
            managePage.AssertFirstPasswordErrorMessage("Incorrect password.");
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void PasswordChangeWithoutNewPassword()
        {
            ManagePage managePage = new ManagePage(this.driver);
            managePage.NavigateTo();
            var user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            managePage.FillLoginForm(user);
            //Assert.IsTrue(managePage.ManageAccountButton.Displayed);
            managePage.ManageAccountButton.Click();
            // Assert.IsTrue(managePage.PasswordChangeButton.Displayed);
            managePage.PasswordChangeButton.Click();
            user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "PasswordChangeWithoutNewPassword");
            managePage.FillChangePasswordForm(user);
            managePage.AssertFirstPasswordErrorMessage("The New password field is required.");
            managePage.AssertSecondPasswordErrorMessage("The new password and confirmation password do not match.");
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void PasswordChangeWithoutConfirmPassword()
        {
            ManagePage managePage = new ManagePage(this.driver);
            managePage.NavigateTo();
            var user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            managePage.FillLoginForm(user);
            //Assert.IsTrue(managePage.ManageAccountButton.Displayed);
            managePage.ManageAccountButton.Click();
            // Assert.IsTrue(managePage.PasswordChangeButton.Displayed);
            managePage.PasswordChangeButton.Click();
            user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "PasswordChangeWithoutConfirmPassword");
            managePage.FillChangePasswordForm(user);
            managePage.AssertFirstPasswordErrorMessage("The new password and confirmation password do not match.");
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void PasswordChangeWithoutData()
        {
            ManagePage managePage = new ManagePage(this.driver);
            managePage.NavigateTo();
            var user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            managePage.FillLoginForm(user);
            //Assert.IsTrue(managePage.ManageAccountButton.Displayed);
            managePage.ManageAccountButton.Click();
            // Assert.IsTrue(managePage.PasswordChangeButton.Displayed);
            managePage.PasswordChangeButton.Click();
            user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "PasswordChangeWithoutData");
            managePage.FillChangePasswordForm(user);
            managePage.AssertFirstPasswordErrorMessage("The Current password field is required.");
            managePage.AssertSecondPasswordErrorMessage("The New password field is required.");
        }

        //must fail
        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void PasswordChangeWithInvalidSymbols()
        {
            ManagePage managePage = new ManagePage(this.driver);
            managePage.NavigateTo();
            var user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin2");
            managePage.FillLoginForm(user);
            //Assert.IsTrue(managePage.ManageAccountButton.Displayed);
            managePage.ManageAccountButton.Click();
            // Assert.IsTrue(managePage.PasswordChangeButton.Displayed);
            managePage.PasswordChangeButton.Click();
            user = AccessExcelData.GetTestData<ManagePageUserModel>("RegisterPageData.xlsx", "DataSet2", "PasswordChangeWithInvalidSymbols");
            managePage.FillChangePasswordForm(user);
            //Origanl Aseert 
            Assert.AreEqual("A potentially dangerous Request.Form value was detected from the client (NewPassword=\"</\").", managePage.InvalidDataErrorMessage.Text);
        }
    }


   
}
