using BartlettAreTheQAs.Attributes;
using BartlettAreTheQAs.Models;
using BartlettAreTheQAs.Pages.LogInPage;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BartlettAreTheQAs
{
    public class BlogLoginPageTests
    {
      
 
      public LogInPage logInPage;

        public IWebDriver driver;

        [SetUp]
        public void Initialized()
        {
            this.driver = BrowserHost.Instance.Application.Browser;
            logInPage = new LogInPage(this.driver);
            logInPage.NavigateTo();

        }

        [TearDown]
        public void LogsandScreenshot()
        {
            TearDownClass TearLogs = new TearDownClass(this.driver);
            TearLogs.TearLogs();
        }


        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void NavigateToLogInPage()
        {
             logInPage.AssertLogInPage("Log in");
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void LoginSuccessfully()
        {
            LogInUserModel user = AccessExcelData.GetTestData<LogInUserModel>("LogInPageData.xlsx", "LogInUserData", "LogInSuccessfully");
            logInPage.FillLogInData(user);
            logInPage.AssertLogInSuccessfully("Log off");
            logInPage.LogOffBtn.Click();
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void LogInWithWrongEmail()
        {
            LogInUserModel user = AccessExcelData.GetTestData<LogInUserModel>("LogInPageData.xlsx", "LogInUserData", "LogInWithWrongEmail");
            logInPage.FillLogInData(user);
            logInPage.AssertMessageInvalidEmail("The Email field is not a valid e-mail address.");
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void LogInWithWrongPassword()
        {
            LogInUserModel user = AccessExcelData.GetTestData<LogInUserModel>("LogInPageData.xlsx", "LogInUserData", "LogInWithWrongPass");
            logInPage.FillLogInData(user);
            logInPage.AssertMessageInvalidPass("Invalid login attempt.");
          
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void LogInWithoutgData()
        {
            logInPage.LogInBtn.Click();
            logInPage.AssertMessageWithoutEmail("The Email field is required.");
            logInPage.AssertMessageWithoutPass("The Password field is required.");

        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void LogInWithoutEmail()
        {
            LogInUserModel user = AccessExcelData.GetTestData<LogInUserModel>("LogInPageData.xlsx", "LogInUserData", "LogInWithoutEmail");
            logInPage.FillLogInData(user);
            logInPage.AssertMessageWithoutEmail("The Email field is required.");
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void LogInWithoutPass()
        {
            LogInUserModel user = AccessExcelData.GetTestData<LogInUserModel>("LogInPageData.xlsx", "LogInUserData", "LogInWithoutPass");
            logInPage.FillLogInData(user);
            logInPage.AssertMessageWithoutPass("The Password field is required.");
        }

        [Test, Property("Priory", 3)]
        [Author("Neli Koynarska")]
        public void LogInRemeberMe()
       {
            
            LogInUserModel user = AccessExcelData.GetTestData<LogInUserModel>("LogInPageData.xlsx", "LogInUserData", "LogInWithCheckBox");
            logInPage.FillLogInData(user);
            logInPage.AssertLogInSuccessfully("Log off");
            logInPage.Driver.Navigate().GoToUrl("https://google.com");
            logInPage.Driver.Navigate().GoToUrl("http://localhost:60634/Article/List");
            logInPage.AssertLogInSuccessfully("Log off");
            
            
        }



 

  
    }


  

    

}
