namespace BartlettAreTheQAs
{
    using BartlettAreTheQAs.Models;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using BartlettAreTheQAs.Attributes;
    using BartlettAreTheQAs.Pages.AdminPage;
    using System.Collections.Generic;
    using System;
    using System.Linq;


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
             
             var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
             AdminPage.FillLoginForm(user);
             Assert.IsTrue(AdminPage.ManageAccountButton.Displayed);
             Assert.IsTrue(AdminPage.AdminButton.Displayed);
            AdminPage.LogoutBtnAsAdmin.Click();
            
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void NavigateToAdminPageUserManage()
        {
           
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
            AdminPage.FillLoginForm(user);
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
            
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
            AdminPage.FillLoginForm(user);
            AdminPage.AdminButton.Click();
            AdminPage.UserManageButton.Click();
            user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUserInfoByAdmin");
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
           
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
            AdminPage.FillLoginForm(user);
            AdminPage.AdminButton.Click();
            AdminPage.UserManageButton.Click();
            user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUserInfoByAdminWithoutPassword");
            Assert.IsTrue(AdminPage.User1EditButton.Displayed);
            AdminPage.User1EditButton.Click();
            AdminPage.FillUserEditForm(user);
            AdminPage.AssertErrorMessage("The Password field is required.");
            //Assert.AreEqual("Users", adminPage.UsersDisplayed.Text);
            AdminPage.LogoutBtnAsAdmin.Click();
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void EditUserInfoByAdminWithoutFullName()
        {
           
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
            AdminPage.FillLoginForm(user);
            AdminPage.AdminButton.Click();
            AdminPage.UserManageButton.Click();
            user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUserInfoByAdminWithoutFullName");
            Assert.IsTrue(AdminPage.User1EditButton.Displayed);
            AdminPage.User1EditButton.Click();
            AdminPage.FillUserEditForm(user);
            AdminPage.AssertErrorMessage("The Full Name field is required.");
            //Assert.AreEqual("Users", adminPage.UsersDisplayed.Text);
            AdminPage.LogoutBtnAsAdmin.Click();
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void EditUserInfoByAdminWithoutAnyData()
        {
           
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
            AdminPage.FillLoginForm(user);
            AdminPage.AdminButton.Click();
            AdminPage.UserManageButton.Click();
            user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUserInfoByAdminWithoutAnyData");
            Assert.IsTrue(AdminPage.User1EditButton.Displayed);
            AdminPage.User1EditButton.Click();
            AdminPage.FillUserEditForm(user);
            AdminPage.AssertConfirmMessage("No changes are made.");
            //Assert.AreEqual("Users", adminPage.UsersDisplayed.Text);
            AdminPage.LogoutBtnAsAdmin.Click();
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void EditUserInfoByAdminWithTwoRoles()
        {
            
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
            AdminPage.FillLoginForm(user);
            AdminPage.AdminButton.Click();
            AdminPage.UserManageButton.Click();
            user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUserInfoByAdminWithTwoRoles");
            Assert.IsTrue(AdminPage.User1EditButton.Displayed);
            AdminPage.User1EditButton.Click();
            AdminPage.FillUserEditForm(user);
            AdminPage.AssertErrorMessage("Please check only one role!");
            //Assert.AreEqual("Users", adminPage.UsersDisplayed.Text);
            AdminPage.LogoutBtnAsAdmin.Click();
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void EditUserInfoByAdminWithoutPasswordMatch()
        {
           
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
            AdminPage.FillLoginForm(user);
            AdminPage.AdminButton.Click();
            AdminPage.UserManageButton.Click();
            user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUserInfoByAdminWithoutPasswordMatch");
            Assert.IsTrue(AdminPage.User1EditButton.Displayed);
            AdminPage.User1EditButton.Click();
            AdminPage.FillUserEditForm(user);
            AdminPage.AssertErrorMessage("The password and confirmation password do not match.");
            //Assert.AreEqual("Users", adminPage.UsersDisplayed.Text);
            AdminPage.LogoutBtnAsAdmin.Click();
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void CheckUserExist()
        {
            
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
            AdminPage.FillLoginForm(user);
            AdminPage.AdminButton.Click();
            Assert.IsTrue(AdminPage.UserManageButton.Displayed);
            AdminPage.UserManageButton.Click();
            Assert.AreEqual("Users", AdminPage.UsersDisplayed.Text);
            int count = 0;
            foreach (IWebElement adminPageAllUsersElement in AdminPage.AllUsersElements)
            {
                
                if (adminPageAllUsersElement.Text.Contains(user.Email))
                {
                    count++;

                }
            }
            Assert.IsTrue(count>0);
            AdminPage.LogoutBtnAsAdmin.Click();
        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        //TO DO
        public void DeleteUser()
        {
           
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
            AdminPage.FillLoginForm(user);
            AdminPage.AdminButton.Click();
            //  Assert.IsTrue(adminPage.UserManageButton.Displayed);
            AdminPage.UserManageButton.Click();
            // Assert.AreEqual("Users", adminPage.UsersDisplayed.Text);

            user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "DeleteUser3");

            Assert.IsTrue(AdminPage.User3DeleteButton.Displayed);
            AdminPage.User3DeleteButton.Click();
            Assert.IsTrue(AdminPage.UserDeleteConfirmBtn.Displayed);
            //to do = register user after delete
            //make dictionary from adminpageallusers list split id email edit delete and change xpath with css selector+ string
            AdminPage.LogoutBtnAsAdmin.Click();

        }
    }
}
