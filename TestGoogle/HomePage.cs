using OpenQA.Selenium;

namespace TestGoogle
{
    public class HomePage
    {
        private static readonly By searchInput = By.XPath("//*[contains(@class, 'gLFyf')]");
        private static readonly By searchButton = By.XPath("//div[@class='lJ9FBc']/center/input[@class='gNO89b']");
        private const string searchItem = "Sweets";

        public static void SearchOnHomePage(WebDriver driver)
        {
            driver.FindElement(searchInput).SendKeys(searchItem);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElement(searchButton).Click();
        }
    }
}
