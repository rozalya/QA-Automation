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
using SeleniumDesignPatternsDemo.Pages.DropablePage;
using SeleniumDesignPatternsDemo.Pages.ResizablePage;
using SeleniumDesignPatternsDemo.Pages.SelectablePage;
using SeleniumDesignPatternsDemo.Pages.SortablePage;
using System.Configuration;
using NUnit.Framework.Interfaces;

namespace SeleniumWebDriverFirstTests
{
    [TestFixture]
    public class TestDragAndDrop
    {
        public IWebDriver driver;

        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
        }

        [TearDown]
        public void CleanUp()
        {
            this.driver.Quit();


        }

        [Test]
        [Author("Drag")]
        public void FindElement()
        {
            var dragPage = new DraggablePage(this.driver);
            driver.Navigate().GoToUrl(dragPage.URL);
            dragPage.AssertDisplayElement();
        }

        [Test]
        [Author("Drag")]
        public void DragLeft()
        {
            var dragPage = new DraggablePage(this.driver);
            driver.Navigate().GoToUrl(dragPage.URL);
            Actions builder = new Actions(driver);
            dragPage.ChangePosition(100, 0);
            dragPage.AssertNewPositionLeft(100);

        }

        [Test]
        [Author("Drag")]
        public void DragTop()
        {
            var dragPage = new DraggablePage(this.driver);
            driver.Navigate().GoToUrl(dragPage.URL);
            Actions builder = new Actions(driver);
            dragPage.ChangePosition(0, 100);
            dragPage.AssertNewPositionTop(100);

        }

        [Test]
        [Author("Drag")]
        public void DragCorner()
        {
            var dragPage = new DraggablePage(this.driver);
            driver.Navigate().GoToUrl(dragPage.URL);
            Actions builder = new Actions(driver);
            dragPage.ChangePosition(100, 100);
            dragPage.AssertNewPositionTop(100);
            dragPage.AssertNewPositionLeft(100);
        }
        [Test]
        [Author("Drag")]
        public void FaliedTestForScreenshot()
        {
            var dragPage = new DraggablePage(this.driver);
            driver.Navigate().GoToUrl(dragPage.URL);
            dragPage.AssertElementText("djdjdjd");
           

        }
        [Test]
        [Author("Drag")]
        public void ElementDetails()
        {
            var dragPage = new DraggablePage(this.driver);
            driver.Navigate().GoToUrl(dragPage.URL);
            dragPage.AssertElementText("Drag me around");
            
        }

        [Test]
        [Author("Drop")]
        public void DragElement()
        {
            var droppablePage = new DropablePage(this.driver);
            droppablePage.DragAndDrop();
            droppablePage.AssertTargetAttributeValue("ui-widget-header ui-droppable ui-state-highlight");
        }

        [Test]
        [Author("Drop")]
        public void DragElementText()
        {
            var droppablePage = new DropablePage(this.driver);
            droppablePage.DragAndDrop();
            droppablePage.AssertTargetAttributeText("Dropped!");
        }

        [Test]
        [Author("Drop")]
        public void DisplayDragElement()
        {
            var droppablePage = new DropablePage(this.driver);
            driver.Navigate().GoToUrl(droppablePage.URL);
            droppablePage.AssertDisplayElementsDrag();

        }

        [Test]
        [Author("Drop")]
        public void DisplayDropElement()
        {
            var droppablePage = new DropablePage(this.driver);
            driver.Navigate().GoToUrl(droppablePage.URL);
            droppablePage.AssertDisplayElementsDrop();

        }

        [Test]
        [Author("Drop")]
        public void OnBorderElement()
        {
            var droppablePage = new DropablePage(this.driver);
            driver.Navigate().GoToUrl(droppablePage.URL);
            droppablePage.DragAndDropOnBorder(68, 100);
            droppablePage.AssertTargetAttributeText("Drop here");

        }

        [Test]
        [Author("Size")]
        public void LocateElenent()
        {
            var resizePage = new ResizablePage(this.driver);
            driver.Navigate().GoToUrl(resizePage.URL);
            resizePage.AssertDisplayResizeElement();

        }

        [Test]
        [Author("Size")]
        public void ResizeWidthElenent()
        {
            var resizePage = new ResizablePage(this.driver);
            driver.Navigate().GoToUrl(resizePage.URL);
            resizePage.IncreaseWidthAndheight(100, 0);
            resizePage.AssertNewSizeWidth(100);

        }

        [Test]
        [Author("Size")]
        public void ResizeHeightElenent()
        {
            var resizePage = new ResizablePage(this.driver);
            driver.Navigate().GoToUrl(resizePage.URL);
            resizePage.IncreaseWidthAndheight(0, 100);
            resizePage.AssertNewSizeHeight( 100);

        }

        [Test]
        [Author("Select")]
        public void LocateElement()
        {
            var selectPage = new SelectablePage(this.driver);
            driver.Navigate().GoToUrl(selectPage.URL);
            selectPage.AssertDisplaySelectElement();

        }

        [Test]
        [Author("Select")]
        public void SelectElement()
        {
            var selectPage = new SelectablePage(this.driver);
            driver.Navigate().GoToUrl(selectPage.URL);
            selectPage.Item1.Click();
            selectPage.AssertSelectedElement("ui-widget-content ui-corner-left ui-selectee ui-selected");

        }

        [Test]
        [Author("Select")]
        public void SelectLastElement()
        {
            var selectPage = new SelectablePage(this.driver);
            driver.Navigate().GoToUrl(selectPage.URL);
            selectPage.Item7.Click();
            selectPage.AssertSelectedLestElement("ui-widget-content ui-corner-left ui-selectee ui-selected");

        }

        [Test]
        [Author("Sort")]
        public void DisplaySortElement()
        {
            var sortablePage = new SortablePage(this.driver);
            driver.Navigate().GoToUrl(sortablePage.URL);
            sortablePage.AssertDisplaySortElement();

        }

        [Test]
        [Author("Sort")]
        public void MoveSortElement()
        {
            var sortablePage = new SortablePage(this.driver);
            driver.Navigate().GoToUrl(sortablePage.URL);
            sortablePage.MoveElement();
            sortablePage.AssertMoveSortElement("Item 2");

        }

        [Test]
        [Author("Sort")]
        public void MoveSortElementUp()
        {
            var sortablePage = new SortablePage(this.driver);
            driver.Navigate().GoToUrl(sortablePage.URL);
            sortablePage.MoveElemenUp();
            sortablePage.AssertMoveSortElement("Item 3");

        }

        public void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        [TearDown]
        public void Cleanup()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status ==TestStatus.Failed)
             {
                string path = ConfigurationManager.AppSettings["Logs"] + TestContext.CurrentContext.Test.Name + ".txt";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.WriteAllText(path, TestContext.CurrentContext.Test.FullName +"       " + TestContext.CurrentContext.TestDirectory);
                var screenshot = ((ITakesScreenshot)this.driver).GetScreenshot();
                screenshot.SaveAsFile(path + TestContext.CurrentContext.Test.Name + ".jpg", ScreenshotImageFormat.Jpeg);
              }
        }
      
    }
}

