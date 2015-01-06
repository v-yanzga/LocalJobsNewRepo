using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Selenium.BrowserMatrix
{
    public static class BrowserStackIE
    {
        public static RemoteWebDriver IEDriver()
        {
            DesiredCapabilities capability = new DesiredCapabilities();
            capability.SetCapability("browser", "IE");
            capability.SetCapability("browser_version", "9.0");
            capability.SetCapability("os", "Windows");
            capability.SetCapability("os_version", "7");
            capability.SetCapability("build", "screenshot test");
            capability.SetCapability("browserstack.debug", "true");
            capability.SetCapability("browserstack.user", "jamescon1");
            capability.SetCapability("browserstack.key", "zNpAXrC3BoxNppsZkBJs");

            string uri = @"http://hub.browserstack.com/wd/hub/";
            return new RemoteWebDriver(new Uri(uri),capability);
        }
    }
}
