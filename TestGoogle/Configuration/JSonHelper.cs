using Microsoft.Extensions.Configuration;

namespace TestGoogle.Configuration
{
    public class JSonHelper
    {
        public static string? GetBrowserType()
        {
            var settings = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@"Configuration/config.json", false, false).Build();
            var browser = settings["browserType"];

            return browser ?? null;
        }
    }
}
