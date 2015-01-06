using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace Selenium.BrowserMatrix
{
    public class Chrome
    {
        public static ChromeDriver ChromeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("test-type");
            ChromeDriverService CDService = ChromeDriverService.CreateDefaultService();
            return new ChromeDriver(CDService, options);
        }
    }
}
