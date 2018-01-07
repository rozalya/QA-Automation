using OpenQA.Selenium;
using SeleniumDesignPatternsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDesignPatternsDemo.Pages.RegistrationPage
{
    public  partial class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver)
            :base(driver)
        {
        }
        public string URL
        {
            get
            {
                return base.url + "registration/";
            }
        }


        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(URL);
        }

        public void FillRegistrationForm(TestUserData user)
        {
            Type(this.FirstName, user.firstName);
            Type(this.LastName, user.lastName);
            ClickOnElements(this.MartialStatus, user.martialStatus);
            ClickOnElements(this.Hobbys, user.hobbys);
            this.CountryOption.SelectByText(user.country);
            this.MounthOption.SelectByText(user.birthMonth);
            this.DayOption.SelectByText(user.birthDay);
            this.YearOption.SelectByText(user.birthYear);
            Type(this.Phone, user.phone);
            Type(this.UserName, user.userName);
            Type(this.Email, user.email);
            this.UploadButton.Click();
            this.Driver.SwitchTo().ActiveElement().SendKeys(user.picture);
            Type(this.Description, user.description);
            Type(this.Password, user.password);
            Type(this.ConfirmPassword, user.confirmPassword);
            this.SubmitButton.Click();
        }

        public static void ClickOnElements( List<IWebElement> elements, string data)
        {
            var conditions = data.Split(',').Select(int.Parse).ToList();
            for (int i = 0; i < conditions.Count; i++)
            {
                if (conditions[i]==1)
                {
                    elements[i].Click();
                }
            }
        }

        private void Type(IWebElement element, string text)
        {
            if(text == null)
            {
                element.Clear();
                element.SendKeys(string.Empty);
            }
            else
            {
                element.Clear();
                element.SendKeys(text);
            }
           
        }
    }
}
