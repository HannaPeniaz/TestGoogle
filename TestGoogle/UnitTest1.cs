using OpenQA.Selenium;

namespace TestGoogle
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            WebDriver driver = Config.GetWebDriver("chrome");
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            HomePage.SearchOnHomePage(driver);
        }
    }
}