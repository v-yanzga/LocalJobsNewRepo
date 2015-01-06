using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Extensions
{
    public static class SearchContextExtensions
    {
        public static IWebElement WaitFindElement(this ISearchContext context, IWebDriver driver, By locator, int timeoutSeconds, bool expectVisible = false, string errorMessage = null, bool failOnTimeout = true)
        {
            var wait = driver.Wait(timeoutSeconds);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));

            if (!string.IsNullOrEmpty(errorMessage))
            {
                wait.Message = errorMessage;
            }

            try
            {
                return wait.Until(d =>
                {
                    var element = context.FindElement(locator);
                    return !expectVisible || element.Displayed ? element : null;
                });
            }
            catch (WebDriverTimeoutException)
            {
                if (failOnTimeout)
                {
                    throw;
                }

                return null;
            }
        }

        /// <remarks>
        /// Downloaded from Visual C# Kicks - http://www.vcskicks.com/
        /// License - http://www.vcskicks.com/license.php  
        /// </remarks>
        public static bool HasElement(this ISearchContext context, By by)
        {
            try
            {
                context.FindElement(by);
            }
            catch (NoSuchElementException)
            {
                return false;
            }

            return true;
        }
    }
}
