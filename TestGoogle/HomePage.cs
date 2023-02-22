using OpenQA.Selenium;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGoogle
{
    public class HomePage
    {
        private static readonly By searchInput = By.XPath("//*[contains(@class, 'gLFyf')]");
        private static readonly By searchButton = By.XPath("//div[@class='lJ9FBc']/center/input[@class='gNO89b']");
        public const string searchItem = "Sweets";

        public static void SearchOnHomePage(WebDriver driver)
        {
            driver.FindElement(searchInput).SendKeys(searchItem);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElement(searchButton).Click();
        }
    }
}
