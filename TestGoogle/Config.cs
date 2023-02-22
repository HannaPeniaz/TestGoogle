using NPOI.Util;
using OpenQA.Selenium;

namespace TestGoogle
{
    public class Config
    {
        public static WebDriver GetWebDriver(string browserName)
        {
            return browserName switch
            {
                "chrome" => new OpenQA.Selenium.Chrome.ChromeDriver(),
                "edge" => new OpenQA.Selenium.Edge.EdgeDriver(),
                _ => throw new RuntimeException("Incorrect BrowserName"),
            };
        }
    }
}
