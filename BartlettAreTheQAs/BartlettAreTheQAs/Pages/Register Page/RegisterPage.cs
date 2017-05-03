using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace BartlettAreTheQAs.Pages.Register_Page
{
    public partial class RegisterPage : BasePage
    {
        public RegisterPage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://localhost:60634/Account/Register");
        }

    }
}
