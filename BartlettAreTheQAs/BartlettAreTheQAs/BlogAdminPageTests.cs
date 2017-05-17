namespace BartlettAreTheQAs
{
    using BartlettAreTheQAs.Models;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using BartlettAreTheQAs.Attributes;
    using BartlettAreTheQAs.Pages.AdminPage;

    [TestFixture]
    class BlogAdminPageTests
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
        public void NavigateToAdminPage()
        {         
             AdminPage adminPage = new AdminPage(this.driver);
             adminPage.NavigateTo();
             var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
             adminPage.FillLoginForm(user);
             Assert.IsTrue(adminPage.ManageAccountButton.Displayed);
             Assert.IsTrue(adminPage.AdminButton.Displayed);
            
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void NavigateToAdminPageUserManage()
        {
            AdminPage adminPage = new AdminPage(this.driver);
            adminPage.NavigateTo();
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
            adminPage.FillLoginForm(user);
            adminPage.AdminButton.Click();
            Assert.IsTrue(adminPage.UserManageButton.Displayed);
            adminPage.UserManageButton.Click();
            Assert.AreEqual("Users", adminPage.UsersDisplayed.Text);
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void EditUserInfoByAdmin()
        {
            AdminPage adminPage = new AdminPage(this.driver);
            adminPage.NavigateTo();
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
            adminPage.FillLoginForm(user);
            adminPage.AdminButton.Click();
            adminPage.UserManageButton.Click();
            user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUserInfoByAdmin");
            Assert.IsTrue(adminPage.User1EditButton.Displayed);
            adminPage.User1EditButton.Click();
            adminPage.FillUserEditForm(user);
            Assert.AreEqual("Users", adminPage.UsersDisplayed.Text);
          
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void EditUserInfoByAdminWithoutPassword()
        {
            AdminPage adminPage = new AdminPage(this.driver);
            adminPage.NavigateTo();
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
            adminPage.FillLoginForm(user);
            adminPage.AdminButton.Click();
            adminPage.UserManageButton.Click();
            user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUserInfoByAdminWithoutPassword");
            Assert.IsTrue(adminPage.User1EditButton.Displayed);
            adminPage.User1EditButton.Click();
            adminPage.FillUserEditForm(user);
            adminPage.AssertErrorMessage("The Password field is required.");
            //Assert.AreEqual("Users", adminPage.UsersDisplayed.Text);

        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void EditUserInfoByAdminWithoutFullName()
        {
            AdminPage adminPage = new AdminPage(this.driver);
            adminPage.NavigateTo();
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
            adminPage.FillLoginForm(user);
            adminPage.AdminButton.Click();
            adminPage.UserManageButton.Click();
            user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUserInfoByAdminWithoutFullName");
            Assert.IsTrue(adminPage.User1EditButton.Displayed);
            adminPage.User1EditButton.Click();
            adminPage.FillUserEditForm(user);
            adminPage.AssertErrorMessage("The Full Name field is required.");
            //Assert.AreEqual("Users", adminPage.UsersDisplayed.Text);

        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void EditUserInfoByAdminWithoutAnyData()
        {
            AdminPage adminPage = new AdminPage(this.driver);
            adminPage.NavigateTo();
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
            adminPage.FillLoginForm(user);
            adminPage.AdminButton.Click();
            adminPage.UserManageButton.Click();
            user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUserInfoByAdminWithoutAnyData");
            Assert.IsTrue(adminPage.User1EditButton.Displayed);
            adminPage.User1EditButton.Click();
            adminPage.FillUserEditForm(user);
            adminPage.AssertConfirmMessage("No changes are made.");
            //Assert.AreEqual("Users", adminPage.UsersDisplayed.Text);

        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void EditUserInfoByAdminWithTwoRoles()
        {
            AdminPage adminPage = new AdminPage(this.driver);
            adminPage.NavigateTo();
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
            adminPage.FillLoginForm(user);
            adminPage.AdminButton.Click();
            adminPage.UserManageButton.Click();
            user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUserInfoByAdminWithTwoRoles");
            Assert.IsTrue(adminPage.User1EditButton.Displayed);
            adminPage.User1EditButton.Click();
            adminPage.FillUserEditForm(user);
            adminPage.AssertErrorMessage("Please check only one role!");
            //Assert.AreEqual("Users", adminPage.UsersDisplayed.Text);

        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void EditUserInfoByAdminWithoutPasswordMatch()
        {
            AdminPage adminPage = new AdminPage(this.driver);
            adminPage.NavigateTo();
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
            adminPage.FillLoginForm(user);
            adminPage.AdminButton.Click();
            adminPage.UserManageButton.Click();
            user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUserInfoByAdminWithoutPasswordMatch");
            Assert.IsTrue(adminPage.User1EditButton.Displayed);
            adminPage.User1EditButton.Click();
            adminPage.FillUserEditForm(user);
            adminPage.AssertErrorMessage("The password and confirmation password do not match.");
            //Assert.AreEqual("Users", adminPage.UsersDisplayed.Text);

        }
    }
}
