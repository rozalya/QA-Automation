using BartlettAreTheQAs.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs.Pages.HomePage
{
    public partial class BlogHomePage : BasePage
    {
        public BlogHomePage(IWebDriver driver) : base(driver)
        {

        }

        public String URL
        {
            get
            {
                return base.URL + "Article/List/";
            }

        }


        public void NavigateTo()
        {
            
            this.Driver.Navigate().GoToUrl(this.URL);
            this.Driver.Manage().Window.Maximize();
        }
       public void FillLogOn(HomePageLogInUserModel user)
        {
            Type(this.Email, user.Email);
            Type(this.Password, user.Password);
            this.LogInBtn.Click();
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

        public  void GototheFirstArctileClickOnEdit()
        {          
            this.FirstArticle.Click();
            this.FirstArticleEditButton.Click();
        }

        public void GototheFirstArctileClickOnDelete()
        {
            this.FirstArticle.Click();
            this.Delete.Click();
        }

        public void GototheFirstArctileClickOnBack()
        {
            this.FirstArticle.Click();
            this.ArctileBack.Click();
        }


        public  void LogInwithNotOwner()
        {
            this.LoginLink.Click();
            var user = AccessExcelData.GetTestData<HomePageLogInUserModel>("RegisterPageData.xlsx", "DataSet2", "ValidLogin");
            this.FillLogOn(user);
        }

        public void LogInwithTestOwnerForCreationDeletion()
        {
            this.LoginLink.Click();
            var user = AccessExcelData.GetTestData<HomePageLogInUserModel>("RegisterPageData.xlsx", "DataSet2", "LoginCreateDeleteArctile");
            this.FillLogOn(user);
        }

        public void CreateArticle()
        {
            this.CreateArticleButton.Click();
            Type(this.CreateArticleTitle, "New Article for deletion");
            Type(this.CreateArticleContent, "Don't use me !!!");
            this.CreateArticle_Btn_To_Create.Click();
          
        }

        public void DeleteArticle()
        {
         //   this.CreateArticleButton.Click();
            Type(this.CreateArticleTitle, "New Article for deletion");
            Type(this.CreateArticleContent, "Don't use me !!!");
            this.CreateArticle_Btn_To_Create.Click();

        }

    }
}
