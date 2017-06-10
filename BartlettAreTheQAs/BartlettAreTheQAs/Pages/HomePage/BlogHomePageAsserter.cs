using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs.Pages.HomePage
{
public static  class BlogHomePageAsserter
    {
        public static void HoverOnLogo(this BlogHomePage page, string text)
        {
            Assert.AreEqual(page.Logo.GetCssValue("color"), text);
        }
        public static void HoverOnFirstArtilce(this BlogHomePage page, string text)
        {
            Assert.AreEqual(page.FirstArticle.GetCssValue("text-decoration"), text);
        }
        public static void FirstArticleText(this BlogHomePage page)
        {
            Assert.IsTrue(page.FirstArticleBody.Displayed);
        }
        public static void CreateLinkDispleyd(this BlogHomePage page)
        {
            Assert.IsTrue(page.CreateLink.Displayed);
        }
        public static void CreateNamePageDisplayed(this BlogHomePage page)
        {
            Assert.IsTrue(page.CreateArticeleNamePage.Displayed);
        }
        public static void LogOffDisplayed(this BlogHomePage page)
        {
            Assert.IsTrue(page.LogOff.Displayed);
        }
        public static void FirstArticleAutor(this BlogHomePage page)
        {
            Assert.IsTrue(page.FirstArticleAutor.Displayed);
        }
        public static void RegisterLinkDisplayed(this BlogHomePage page)
        {
            Assert.IsTrue(page.RegisterLink.Displayed);
        }
        public static void LonInLinkDisplayed(this BlogHomePage page)
        {
            Assert.IsTrue(page.LoginLink.Displayed);
        }
        public static void HoverOnRegisterLink(this BlogHomePage page, string text)
        {
            Assert.AreEqual(page.RegisterLink.GetCssValue("color"), text);
        }
        public static void HoverOnLogInLink(this BlogHomePage page, string text)
        {
            Assert.AreEqual(page.LoginLink.GetCssValue("color"), text);
        }
        public static void LogInLinkClick(this BlogHomePage page)
        {
            Assert.IsTrue(page.LoadPage.Displayed);
        }
        public static void RegisterLinkClick(this BlogHomePage page)
        {
            Assert.IsTrue(page.LoadPageRegister.Displayed);
        }
        public static void LogInHelloDiplay(this BlogHomePage page)
        {
            Assert.IsTrue(page.Hello.Displayed);
        }
        public static void LogInManageDisplay(this BlogHomePage page)
        {
            Assert.IsTrue(page.Manage.Displayed);
        }
        public static void LogoDisplayed(this BlogHomePage page)
        {
            Assert.IsTrue(page.Logo.Displayed);
        }
        public static void FirstArtileTitleDisplayed(this BlogHomePage page)
        {
            Assert.IsTrue(page.FirstArticleText.Displayed);
        }

        public static void RegisterURL(this BlogHomePage page)
        {
            Assert.IsTrue(page.Driver.Url.Contains("http://localhost:60634/Account/Login"));
        }

    }
}