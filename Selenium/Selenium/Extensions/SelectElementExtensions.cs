using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Selenium.Extensions
{
    public static class SelectElementExtensions
    {
        public static void SelectByText(this SelectElement selectElement,string text,int timePreExecute = 500)
        {
            try
            {
                Thread.Sleep(timePreExecute);
                selectElement.SelectByText(text);
            }
            catch (NoSuchElementException)
            {
                throw;
            }
            catch
            {
                SelectByText(selectElement, text, timePreExecute);
            }
        }
    }
}
