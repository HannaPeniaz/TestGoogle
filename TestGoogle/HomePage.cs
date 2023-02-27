using NUnit.Framework;
using OpenQA.Selenium;

namespace TestGoogle
{
    public class HomePage
    {
        private static readonly By searchInput = By.XPath("//*[contains(@class, 'gLFyf')]");
        private static readonly By searchButton = By.XPath("//div[@class='lJ9FBc']/center/input[@class='gNO89b']");
        private static readonly By linkNameInput = By.XPath("//h3[contains(@class,'LC20lb MBeuO DKV0Md')]");

        public static void SearchOnHomePage(IWebDriver driver,string searchText)
        {
            driver.FindElement(searchInput).SendKeys(searchText);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElement(searchButton).Click();
            var textInLink = driver.FindElements(linkNameInput).First().Text.ToLower();
            var wordsInSearchText = searchText.Split(' ');
            foreach (var item in wordsInSearchText)
            {
                Assert.That(textInLink, Does.Contain(item.ToLower()));
            }
        }
    }
}
