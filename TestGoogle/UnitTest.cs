using NUnit.Framework;
using OpenQA.Selenium;

namespace TestGoogle
{
    public class Tests
    {
        private IWebDriver driver;
        private static readonly string searchText = "mustang shelby";

        [SetUp]
        public void Setup()
        {
            driver = Configuration.WebDriver.GetWebDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            HomePage.SearchOnHomePage(driver,searchText);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}