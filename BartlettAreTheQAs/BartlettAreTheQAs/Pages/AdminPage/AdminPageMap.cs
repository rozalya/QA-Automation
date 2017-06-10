namespace BartlettAreTheQAs.Pages.AdminPage
{
    using OpenQA.Selenium;
    using System.Collections.Generic;
    using System.Linq;

    public partial class AdminPage
    {
      

        public IWebElement LoginButton
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/input")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/input"));


            }
        }
        
        public IWebElement ManageAccountButton
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[2]/a")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[2]/a"));


            }
        }

        public IWebElement AdminButton
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[1]/a")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[1]/a"));


            }
        }

        public IWebElement PasswordChangeButton
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/dl/dd/a")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/dl/dd/a"));


            }
        }

        public IWebElement ConfirmPasswordChangeButton
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[5]/div/input")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[5]/div/input"));


            }
        }

        public IWebElement UserManageButton
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[1]/ul/li/a"));
            }
        }

        public IWebElement UsersDisplayed
        {
            get { return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/h2")); }
        }

        public IWebElement UserEmail
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.Id("User_Email")));
                return this.Driver.FindElement(By.Id("User_Email"));

            }
        }

        public IWebElement Email
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.Id("Email")));
                return this.Driver.FindElement(By.Id("Email"));

            }
        }

        public IWebElement FullName
        {
            get { return this.Driver.FindElement(By.Id("User_FullName")); }
        }

        public IWebElement Password
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.Id("Password")));
                return this.Driver.FindElement(By.Id("Password"));

            }
        }

        public IWebElement CurrentPassword
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.Id("OldPassword")));
                return this.Driver.FindElement(By.Id("OldPassword"));

            }
        }

        public IWebElement NewPassword
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.Id("NewPassword")));
                return this.Driver.FindElement(By.Id("NewPassword"));

            }
        }

        public IWebElement ConfirmPassword
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.Id("ConfirmPassword")));
                return this.Driver.FindElement(By.Id("ConfirmPassword"));

            }
        }

        public IWebElement RoleUserCheckbox
        {
            get { return this.Driver.FindElement(By.XPath("//*[@id=\"Roles_1__IsSelected\"]")); }
        }

        public IWebElement RoleAdminCheckbox
        {
            get { return this.Driver.FindElement(By.XPath("//*[@id=\"Roles_0__IsSelected\"]")); }
        }

        public IWebElement User1EditButton
        {
            get { return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/table/tbody/tr[7]/td[3]/a[1]")); }
        }

        public IWebElement User3DeleteButton
        {
            get
            {
               // return DeleteUsersBtn["user3@a.a"];
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/table/tbody/tr[4]/td[3]/a[2]"));
            }
        }

        public IWebElement UserDeleteConfirmBtn
        {
            get { return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[3]/div/input")); }
        }

        public IWebElement EditUserConfirmButton
        {
            get { return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/input")); }
        }

        public List<IWebElement> AllUsersElements
        {
            get
            {
               return this.Driver.FindElements(
                    By.CssSelector("body > div.container.body-content > div > div > table > tbody > tr")).ToList();
            }
        }

        public IWebElement PasswordErrorMessage
        {
            get { return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/ul/li")); }
        }

        public IWebElement SuccessChangeMessage
        {
            get { return this.Driver.FindElement(By.XPath("/html/body/div[2]/p")); }
        }

        public IWebElement LogoutBtnAsUser
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[3]/a")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[3]/a"));

            }
        }

        public IWebElement LogoutBtnAsAdmin
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[4]/a")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[4]/a"));

            }
        }

        //проба грешка май се получи

        public IList<IWebElement> All
        {
            get {return this.Driver.FindElements(By.CssSelector("body > div.container.body-content > div > div > table > tbody > tr>td")); }
        }

        public IList<IWebElement> AllEditDeleteBtn
        {
            get { return this.Driver.FindElements(By.CssSelector("body > div.container.body-content > div > div > table > tbody > tr>td>a")); }
        }

        public List<string> UsersId
        {
            get
            {
                List<string> usersId = new List<string>();
                for (int index = 0; index < All.Count; index++)
                {

                    if (index % 3 == 0)
                    {
                        usersId.Add(All[index].Text);
                    }

                }
                return usersId;
            }
        }

        public List<string> UsersEmail
        {
            get
            {
                List<string> usersEmail = new List<string>();
                for (int index = 0; index < All.Count; index++)
                {

                    if (index % 3 == 1)
                    {
                        usersEmail.Add(All[index].Text);
                    }

                }
                return usersEmail;
            }
        }

        public Dictionary<string, IWebElement> EditUsersBtn
        {
            get
            {
                Dictionary<string, IWebElement> editUsersBtn = new Dictionary<string, IWebElement>();
                int j = 0;
                for (int i = 0; i < AllEditDeleteBtn.Count; i++, j += 2)
                {

                    editUsersBtn[UsersEmail[i]] = AllEditDeleteBtn[j];
                   

                }
                return editUsersBtn;
            }
        }

        public Dictionary<string, IWebElement> DeleteUsersBtn
        {
            get
            {
                Dictionary<string, IWebElement> deleteUsersBtn = new Dictionary<string, IWebElement>();
                int j = 0;
                for (int i = 0; i < AllEditDeleteBtn.Count; i++, j += 2)
                {

                    
                    deleteUsersBtn[UsersEmail[i]] = AllEditDeleteBtn[j + 1];

                }
                return deleteUsersBtn;
            }
        }

        

    }
}
