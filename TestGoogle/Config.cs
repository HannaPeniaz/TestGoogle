using NPOI.Util;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
