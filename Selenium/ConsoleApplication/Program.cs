using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium.BrowserMatrix;
using OpenQA.Selenium;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = Chrome.ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(@"http://www.google.com");
            Console.ReadKey();
        }
    }
}
