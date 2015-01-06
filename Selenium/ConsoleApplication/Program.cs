using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium.BrowserMatrix;
using OpenQA.Selenium;
using System.Threading;
using Selenium.Extensions;

namespace ConsoleApplication
{
    class Program
    {
        /*
         * param:
         * agrs[0]: Destination URL
         * args[1]: Verify code
         * args[2]: username
         * args[3]: password
         **/
        static void Main(string[] args)
        {
            IWebDriver driver = Chrome.ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(args[0]);

            Thread.Sleep(500);
            driver.FindElement(By.CssSelector("input[name='login']")).SendKeys(args[2]);
            driver.FindElement(By.CssSelector("input[name='password']")).SendKeys(args[3]);

            Thread.Sleep(500);
            driver.WaitForURLChange(() => driver.FindElement(By.CssSelector("input[name='commit']")).Click());


            driver.FindElement(By.CssSelector("input[name='otp']")).SendKeys(args[1]);
            driver.WaitForURLChange(() => driver.FindElement(By.CssSelector("div button")).Click());
            Console.ReadKey();
            driver.Close();
        }
    }
}
