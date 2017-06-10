namespace BartlettAreTheQAs
{
    using Models;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using Attributes;
    using Pages.AdminPage;


    [TestFixture]
    class BlogAdminPageTests
    {
        public IWebDriver driver;
        public AdminPage AdminPage;

        [SetUp]
        public void Initialized()
        {
            this.driver = BrowserHost.Instance.Application.Browser;
            this.AdminPage = new AdminPage(this.driver);
            AdminPage.NavigateTo();
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
            AdminPage.FillLoginForm(user);
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
            Assert.IsTrue(AdminPage.ManageAccountButton.Displayed);
            Assert.IsTrue(AdminPage.AdminButton.Displayed);
            AdminPage.LogoutBtnAsAdmin.Click();

        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void NavigateToAdminPageUserManage()
        {

            AdminPage.AdminButton.Click();
            Assert.IsTrue(AdminPage.UserManageButton.Displayed);
            AdminPage.UserManageButton.Click();
            Assert.AreEqual("Users", AdminPage.UsersDisplayed.Text);
            AdminPage.LogoutBtnAsAdmin.Click();
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void EditUserInfoByAdmin()
        {

            AdminPage.AdminButton.Click();
            AdminPage.UserManageButton.Click();
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUserInfoByAdmin");
            Assert.IsTrue(AdminPage.User1EditButton.Displayed);
            AdminPage.User1EditButton.Click();
            AdminPage.FillUserEditForm(user);
            Assert.AreEqual("Users", AdminPage.UsersDisplayed.Text);
            AdminPage.LogoutBtnAsAdmin.Click();
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void EditUserInfoByAdminWithoutPassword()
        {

            AdminPage.AdminButton.Click();
            AdminPage.UserManageButton.Click();
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUserInfoByAdminWithoutPassword");
            Assert.IsTrue(AdminPage.User1EditButton.Displayed);
            AdminPage.User1EditButton.Click();
            AdminPage.FillUserEditForm(user);
            AdminPage.AssertErrorMessage("The Password field is required.");

            AdminPage.LogoutBtnAsAdmin.Click();
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void EditUserInfoByAdminWithoutFullName()
        {

            AdminPage.AdminButton.Click();
            AdminPage.UserManageButton.Click();
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUserInfoByAdminWithoutFullName");
            Assert.IsTrue(AdminPage.User1EditButton.Displayed);
            AdminPage.User1EditButton.Click();
            AdminPage.FillUserEditForm(user);
            AdminPage.AssertErrorMessage("The Full Name field is required.");

            AdminPage.LogoutBtnAsAdmin.Click();
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void EditUserInfoByAdminWithoutAnyData()
        {

            AdminPage.AdminButton.Click();
            AdminPage.UserManageButton.Click();
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUserInfoByAdminWithoutAnyData");
            Assert.IsTrue(AdminPage.User1EditButton.Displayed);
            AdminPage.User1EditButton.Click();
            AdminPage.FillUserEditForm(user);
            AdminPage.AssertConfirmMessage("No changes are made.");

            AdminPage.LogoutBtnAsAdmin.Click();
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void EditUserInfoByAdminWithTwoRoles()
        {
            AdminPage.AdminButton.Click();
            AdminPage.UserManageButton.Click();
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUserInfoByAdminWithTwoRoles");
            Assert.IsTrue(AdminPage.User1EditButton.Displayed);
            AdminPage.User1EditButton.Click();
            AdminPage.FillUserEditForm(user);
            AdminPage.AssertErrorMessage("Please check only one role!");
          
            AdminPage.LogoutBtnAsAdmin.Click();
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void EditUserInfoByAdminWithoutPasswordMatch()
        {
            AdminPage.AdminButton.Click();
            AdminPage.UserManageButton.Click();
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUserInfoByAdminWithoutPasswordMatch");
            Assert.IsTrue(AdminPage.User1EditButton.Displayed);
            AdminPage.User1EditButton.Click();
            AdminPage.FillUserEditForm(user);
            AdminPage.AssertErrorMessage("The password and confirmation password do not match.");
          
            AdminPage.LogoutBtnAsAdmin.Click();
        }

  /*      [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void CheckUserExist()
        {

            AdminPage.AdminButton.Click();
            
            AdminPage.UserManageButton.Click();
            Assert.AreEqual("Users", AdminPage.UsersDisplayed.Text);

            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");

            int count = 0;
            foreach (IWebElement adminPageAllUsersElement in AdminPage.AllUsersElements)
            {

                if (adminPageAllUsersElement.Text.Contains(user.Email))
                {
                    count++;

                }
            }
            Assert.IsTrue(count > 0);
            AdminPage.LogoutBtnAsAdmin.Click();
        }
*/
        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        //TO DO
        public void DeleteUser()
        {
            AdminPage.AdminButton.Click();
          
            AdminPage.UserManageButton.Click();
           
           var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "DeleteUser3");

            Assert.IsTrue(AdminPage.User3DeleteButton.Displayed);
            AdminPage.User3DeleteButton.Click();
            Assert.IsTrue(AdminPage.UserDeleteConfirmBtn.Displayed);
            //to do = register user after delete
            //make dictionary from adminpageallusers list split id email edit delete and change xpath with css selector+ string
            AdminPage.LogoutBtnAsAdmin.Click();

        }
    }
}
