using BartlettAreTheQAs.Models;
using BartlettAreTheQAs.Pages.Register_Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BartlettAreTheQAs.Attributes;
using BartlettAreTheQAs.Pages.AdminPage;
using BartlettAreTheQAs.Pages.LogInPage;

namespace BartlettAreTheQAs
{
    [TestFixture]
    class BlogAdminPageTests
    {
        [TearDown]
        public void LogsandScreenshot()
        {
            TearDownClass TearLogs = new TearDownClass();
            TearLogs.TearLogs();

        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void NavigateToAdminPage()
        {         
             AdminPage adminPage = new AdminPage();
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
            AdminPage adminPage = new AdminPage();
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
            AdminPage adminPage = new AdminPage();
            adminPage.NavigateTo();
            var user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "AdminLogin");
            adminPage.FillLoginForm(user);
            adminPage.AdminButton.Click();
            adminPage.UserManageButton.Click();
            user = AccessExcelData.GetTestData<AdminPageUserModel>("RegisterPageData.xlsx", "DataSet2", "EditUser");
            Assert.IsTrue(adminPage.User1EditButton.Displayed);
            adminPage.User1EditButton.Click();
            adminPage.FillUserEditForm(user);
            Assert.AreEqual("Users", adminPage.UsersDisplayed.Text);
            //must edit checkboxes
        }

        
    }
}
