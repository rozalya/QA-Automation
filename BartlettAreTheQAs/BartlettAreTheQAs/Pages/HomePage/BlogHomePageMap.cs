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
        public IWebElement Logo
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("html/body/div[1]/div/div[1]/a")));
                return this.Driver.FindElement(By.XPath("html/body/div[1]/div/div[1]/a"));
              

            }
        }

        public IWebElement FirstArticle
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/article/header/h2/a")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/article/header/h2/a"));


            }
        }
        public IWebElement FirstArticleTitle
        {
            get
            {
                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/article/header/h2")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/article/header/h2"));
            }
        }

        public IWebElement FirstArticleText
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/article/p")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/article/p"));


            }
        }
        public IWebElement FirstArticleEditButton
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/article/footer/a[1]")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/article/footer/a[1]"));


            }
        }
        public IWebElement FirstArticleAutor
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/article/footer/small")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/article/footer/small"));


            }
        }
        public IWebElement RegisterLink
        {
            get
            {
               this.Wait.Until(w => w.FindElement(By.Id("registerLink")));
                return this.Driver.FindElement(By.Id("registerLink"));
                
            }
        }
        public IWebElement LoginLink
        {
            get
            {
                this.Wait.Until(w => w.FindElement(By.Id("loginLink")));
                return this.Driver.FindElement(By.Id("loginLink"));

            }
        }
        public IWebElement LoadPage
        {
            get
            {
                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/div/h2")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/h2"));

            }
        }
        public IWebElement LoadPageRegister
        {
            get
            {
                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/div/h2")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/h2"));

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
        public IWebElement Password
        {
            get
            {
                this.Wait.Until(w => w.FindElement(By.Id("Password")));
                return this.Driver.FindElement(By.Id("Password"));

            }
        }
        public IWebElement LogInBtn
        {
            get
            {
                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/input")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/input"));

            }
        }
        public IWebElement Hello
        {
            get
            {
                this.Wait.Until(w => w.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[2]/a")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[2]/a"));

            }
        }

        public IWebElement LogOff
        {
            get
            {
                this.Wait.Until(w => w.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[3]/a")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li[3]/a"));

            }
        }


        public IWebElement Delete
        {
            get
            {
                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/article/footer/a[2]")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/article/footer/a[2]"));

            }
        }

        public IWebElement ArctileBack
        {
            get
            {
                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/article/footer/a[3]")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/article/footer/a[3]"));

            }
        }

        public IWebElement CreateArticleButton
        {
            get
            {
                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[1]/div/div[2]/form/ul/li[1]/a")));
                return this.Driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/form/ul/li[1]/a"));

            }
        }


        public IWebElement CreateArticleTitle
        {
            get
            {
                this.Wait.Until(w => w.FindElement(By.Id("Title")));
                return this.Driver.FindElement(By.Id("Title"));

            }
        }

        public IWebElement CreateArticleContent
        {
            get
            {
                this.Wait.Until(w => w.FindElement(By.Id("Content")));
                return this.Driver.FindElement(By.Id("Content"));

            }
        }

        public IWebElement CreateArticle_Btn_To_Create
        {
            get
            {
                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/input")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/input"));

            }
        }


    }
}
