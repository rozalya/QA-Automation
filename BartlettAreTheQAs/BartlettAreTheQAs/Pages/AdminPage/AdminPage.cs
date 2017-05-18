namespace BartlettAreTheQAs.Pages.AdminPage
{
    using System;
    using OpenQA.Selenium;
    using BartlettAreTheQAs.Models;
    public partial class AdminPage : BasePage
    {
        public AdminPage(IWebDriver driver) : base(driver)
        {
        }

        public String URL
        {
            get
            {
                return base.URL + "Account/Login/";
            }

        }

        public void NavigateTo()
        {

            this.Driver.Navigate().GoToUrl(this.URL);
            this.Driver.Manage().Window.Maximize();

        }

        public void FillLoginForm(AdminPageUserModel user)
        {
            Type(this.Email, user.Email);
            Type(this.Password, user.Password);
            this.LoginButton.Click();
        }

        public void FillChangePasswordForm(AdminPageUserModel user)
        {
            Type(this.CurrentPassword, user.CurrentPassword);
            Type(this.NewPassword, user.NewPassword);
            Type(this.ConfirmPassword, user.ConfirmPassword);
            this.ConfirmPasswordChangeButton.Click();
        }

        public void FillUserEditForm(AdminPageUserModel user)
        {
            Type(this.UserEmail, user.UserEmail);
            Type(this.FullName, user.FullName);
            Type(this.Password, user.Password);
            Type(this.ConfirmPassword, user.ConfirmPassword);
            ClickOnRolesCheckboxes(user);
            this.EditUserConfirmButton.Click();
        }

        private void ClickOnRolesCheckboxes(AdminPageUserModel user)
        {
            switch (user.RoleUser)
            {
                case "1":
                    if (!this.RoleUserCheckbox.Selected)
                    {
                        RoleUserCheckbox.Click();
                    }
                    break;
                case "0":
                    if (this.RoleUserCheckbox.Selected)
                    {
                        RoleUserCheckbox.Click();
                    }
                    break;
            }

            switch (user.RoleAdmin)
            {
                case "1":
                    if (!this.RoleAdminCheckbox.Selected)
                    {
                        RoleAdminCheckbox.Click();
                    }
                    break;
                case "0":
                    if (this.RoleAdminCheckbox.Selected)
                    {
                        RoleAdminCheckbox.Click();
                    }
                    break;
            }
        }

        private void Type(IWebElement element, string text)
        {
            if (text == null)
            {
                element.Clear();
            }
            else
            {
                element.Clear();
                element.SendKeys(text);
            }

        }

       
    }
}
