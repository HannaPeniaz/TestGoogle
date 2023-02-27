using NPOI.Util;
using OpenQA.Selenium;

namespace TestGoogle.Configuration
{
    public class WebDriver
    {
        public static IWebDriver GetWebDriver()
        {
            var browserType = JSonHelper.GetBrowserType();

            return browserType switch
            {
                "chrome" => new OpenQA.Selenium.Chrome.ChromeDriver(),
                "edge" => new OpenQA.Selenium.Edge.EdgeDriver(),
                _ => throw new RuntimeException("Incorrect BrowserName"),
            };
        }
    }
}
