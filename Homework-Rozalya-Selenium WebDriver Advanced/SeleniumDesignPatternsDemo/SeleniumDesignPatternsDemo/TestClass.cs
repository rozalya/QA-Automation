using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.IE;
using SeleniumDesignPatternsDemo.Models;
using SeleniumDesignPatternsDemo.Pages.HomePage;
using SeleniumDesignPatternsDemo.Pages.RegistrationPage;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System;
using OpenQA.Selenium.Interactions;
using SeleniumDesignPatternsDemo.Pages.DraggablePage;

namespace SeleniumWebDriverFirstTests
{
    [TestFixture]
    public class RegisterInDemoQA
    {
        public IWebDriver driver;

        [SetUp]
        public void Init()
        {
            //this.driver = new InternetExplorerDriver();
            this.driver = new ChromeDriver();
        }

        [TearDown]
        public void CleanUp()
        {
            this.driver.Quit();

            //If you use Internet Explorer and browser don't close after test
            //Process cmd = new Process();
            //cmd.StartInfo.FileName = "cmd.exe";
            //cmd.StartInfo.RedirectStandardInput = true;
            //cmd.StartInfo.RedirectStandardOutput = true;
            //cmd.StartInfo.CreateNoWindow = true;
            //cmd.StartInfo.UseShellExecute = false;
            //cmd.Start();
            //
            //cmd.StandardInput.WriteLine("taskkill /F /IM iexplore.exe");
            //cmd.StandardInput.Flush();
            //cmd.StandardInput.Close();
            //Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

        [Test, Property("Priority", 2)]
        [Author("Ventsislav Ivanov")]
        public void NavigateToRegistrationPage()
        {
            var homePage = new HomePage(driver);
            var registrationPage = new RegistrationPage(driver);
            PageFactory.InitElements(this.driver, homePage);

            homePage.NavigateTo();
            homePage.RegirstratonButton.Click();

            registrationPage.AssertRegistrationPageIsOpen("Registration");
        }

        //Test with Valid Data, if you want to execute it change Username and Mail
        //[Test]
        //public void RegistrateWithValidData()
        //{
        //    var regPage = new RegistrationPage(this.driver);
        //    RegistrationUser user = new RegistrationUser("Ventsislav",
        //                                                 "Ivanov",
        //                                                 new List<bool>(new bool[] { true, false, false }),
        //                                                 new List<bool>(new bool[] { true, true, true }),
        //                                                 "Bulgaria",
        //                                                 "3",
        //                                                 "1",
        //                                                 "1989",
        //                                                 "8888888888",
        //                                                 "Buro",
        //                                                 "burkata@abv.bg",
        //                                                 @"C:\Users\Buro\Desktop\Seminar\Pics\enviroment.jpg",
        //                                                 "OPSA",
        //                                                 "12345678",
        //                                                 "12345678");
        //
        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);
        //
        //    regPage.AssesrtSuccessMessage("Thank you for your registration");
        //}

        //[Test]
        //public void RegistrateWithOutFirstName()
        //{
            
        //    var regPage = new RegistrationPage(this.driver);
        //    driver.Navigate().GoToUrl(regPage.URL);
        //    //var TestUserData = ExcelDataAccess.GetTestData("Login");
        //    //RegistrationUser user = new RegistrationUser(TestUserData.firstName, TestUserData.lastName, TestUserData.martialStatus, TestUserData.hobbys, TestUserData.country, TestUserData.birthMonth, TestUserData.birthDay, TestUserData.birthYear, TestUserData.phone, TestUserData.userName, TestUserData.email, TestUserData.picture, TestUserData.description, TestUserData.password, TestUserData.confirmPassword);
        //    RegistrationUser user = new RegistrationUser("",
        //                                                 "",
        //                                                 new List<bool>(new bool[] { true, false, false }),
        //                                                 new List<bool>(new bool[] { true, true, true }),
        //                                                 "Bulgaria",
        //                                                 "3",
        //                                                 "1",
        //                                                 "1989",
        //                                                 "8888888888",
        //                                                 "Buro",
        //                                                 "burkata@abv.bg",
        //                                                 @"C:\Users\rozalia\Desktop\Seminar\Pics\enviroment.jpg",
        //                                                 "OPSA",
        //                                                 "12345678",
        //                                                 "12345678");

        //    regPage.NavigateTo();
        //    regPage.FillRegistrationForm(user);

        //    regPage.AssertNamesErrorMessage("This field is required");
        //}
        

        [Test]
        public void RegistrateWithOutFamilyName()
        {
            var regPage = new RegistrationPage(this.driver);
            driver.Navigate().GoToUrl(regPage.URL);
            var testUser = ExcelDataAccess.GetTestData("Login");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(testUser);
            regPage.AssertNamesErrorMessageLastName("This field is required");
        }

        [Test]
        public void RegistrateWithOutPhoneNumber()
        {
            var regPage = new RegistrationPage(this.driver);
            driver.Navigate().GoToUrl(regPage.URL);
            var testUser = ExcelDataAccess.GetTestData("NoPhone");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(testUser);
            regPage.AssertPhoneErrorMessage("This field is required");
        }
        [Test]
        public void WithoutName()
        {
            var regPage = new RegistrationPage(this.driver);
            driver.Navigate().GoToUrl(regPage.URL);
            var testUser = ExcelDataAccess.GetTestData("NoNames");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(testUser);
           regPage.AssertNamesErrorMessage("* This field is required");

        }

        [Test]
        public void WeakPass()
        {
            var regPage = new RegistrationPage(this.driver);
            driver.Navigate().GoToUrl(regPage.URL);
            var testUser = ExcelDataAccess.GetTestData("WeakPass");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(testUser);
            regPage.AssertShortPassErrorMessage("Very weak");

        }

        [Test]
        public void NoEmail()
        {
            var regPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl(regPage.URL);
            var testUser = ExcelDataAccess.GetTestData("NoEmail");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(testUser);
            regPage.AssertMessagesForNoEmail("* This field is required");
        }

        [Test]
        public void ShortPhoneNumber()
        {
            var regPage = new RegistrationPage(this.driver);
            driver.Navigate().GoToUrl(regPage.URL);
            var testUser = ExcelDataAccess.GetTestData("ShortPhoneNumber");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(testUser);
            regPage.AssertMessagesForShortPhone("* Minimum 10 Digits starting with Country Code");
        }

        [Test]
        public void WithoutHobby()
        {
            var regPage = new RegistrationPage(this.driver);
            driver.Navigate().GoToUrl(regPage.URL);
            var testUser = ExcelDataAccess.GetTestData("WithoutHobby");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(testUser);
            regPage.AssertMessagesNoHobby("* This field is required");

        }

        [Test]
        public void DublicateUserName()
        {
            var regPage = new RegistrationPage(this.driver);
            driver.Navigate().GoToUrl(regPage.URL);
            var testUser = ExcelDataAccess.GetTestData("DublicateUserName");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(testUser);
            regPage.AssertMessagesDublicateUser(": Username already exists");

        }

        [Test]
        public void InvalidEmail()
        {
            var regPage = new RegistrationPage(this.driver);
            driver.Navigate().GoToUrl(regPage.URL);
            var testUser = ExcelDataAccess.GetTestData("InvalidEmail");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(testUser);
            regPage.AssertMessagesInvalideEmail("* Invalid email address");
        }

        [Test]
        public void DuplicateEmail()
        {
            var regPage = new RegistrationPage(this.driver);
            driver.Navigate().GoToUrl(regPage.URL);
            var testUser = ExcelDataAccess.GetTestData("DuplicateEmail");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(testUser);
            regPage.AssertNamesErrorMessageDublicateEmail(": E-mail address already exists");
        }

        [Test]
        public void PasswordMismatch()
        {
            var regPage = new RegistrationPage(this.driver);
            driver.Navigate().GoToUrl(regPage.URL);
            var testUser = ExcelDataAccess.GetTestData("PasswordMismatch");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(testUser);
            regPage.AssertErrorMessagePasswordMismatch("* Fields do not match");


        }

        [Test]
        public void StrengthIndicatorMismatch()
        {
            var regPage = new RegistrationPage(this.driver);
            driver.Navigate().GoToUrl(regPage.URL);
            var testUser = ExcelDataAccess.GetTestData("StrengthIndicatorMismatch");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(testUser);
            regPage.AssertErrorMessageStrengthIndicatorMismatch("Mismatch");
        }

        [Test]
        public void RegistrateWithOutUserName()
        {
            var regPage = new RegistrationPage(this.driver);
            driver.Navigate().GoToUrl(regPage.URL);
            var testUser = ExcelDataAccess.GetTestData("RegistrateWithOutUserName");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(testUser);
            regPage.AssertNamesErrorMessageNoUserName("* This field is required");


        }
        [Test]
        public void RegistrateWithInvalidPictureFormat()
        {
            var regPage = new RegistrationPage(this.driver);
            driver.Navigate().GoToUrl(regPage.URL);
            var testUser = ExcelDataAccess.GetTestData("RegistrateWithInvalidPictureFormat");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(testUser);
            regPage.AssertErrorMessageInvaldeFile("* Invalid File");


        }

        [Test]
        public void WithoutPhoneAndUsername()
        {

            var regPage = new RegistrationPage(this.driver);
            driver.Navigate().GoToUrl(regPage.URL);
            var testUser = ExcelDataAccess.GetTestData("WithoutPhoneAndUsername");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(testUser);
            regPage.AssertNamesErrorMessageNoUserName("* This field is required");
            regPage.AssertPhoneErrorMessage("* This field is required");


        }

        [Test]
        public void WithoutHoobyAndPhone()
        {
            var regPage = new RegistrationPage(this.driver);
            driver.Navigate().GoToUrl(regPage.URL);
            var testUser = ExcelDataAccess.GetTestData("WithoutHoobyAndPhone");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(testUser);
            regPage.AssertMessagesNoHobby("* This field is required");
            regPage.AssertPhoneErrorMessage("* This field is required");


        }

        [Test]
        public void WithoutEmailAndPhone()
        {
            var regPage = new RegistrationPage(this.driver);
            driver.Navigate().GoToUrl(regPage.URL);
            var testUser = ExcelDataAccess.GetTestData("WithoutEmailAndPhone");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(testUser);
            regPage.AssertMessagesForNoEmail("* This field is required");
            regPage.AssertPhoneErrorMessage("* This field is required");


        }

        [Test]
        public void WithoutSecondNameAndEmail()
        {
            var regPage = new RegistrationPage(this.driver);
            driver.Navigate().GoToUrl(regPage.URL);
            var testUser = ExcelDataAccess.GetTestData("WithoutSecondNameAndEmail");
            regPage.NavigateTo();
            regPage.FillRegistrationForm(testUser);
            regPage.AssertMessagesForNoEmail("* This field is required");
            regPage.AssertNamesErrorMessageLastName("This field is required");


        }

       


        public void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}
