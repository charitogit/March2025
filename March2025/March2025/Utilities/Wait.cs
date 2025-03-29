using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March2025.Utilities
{
    public class Wait
    {
       
        public static void waitToBeVisible(IWebDriver driver, string locType, string locValue, int seconds)

        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0,seconds));

         if (locType == "XPath")

            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locValue)));
            }

         if (locType == "Id")

            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locValue)));
            }
           

        }

        public static void waitToBeClickable(IWebDriver driver, string locType, string locValue, int seconds)

        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locType == "XPath")

            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locValue)));
            }

            if (locType == "Id")

            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(locValue)));
            }


        }
    }
}
