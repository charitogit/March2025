using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March2025.Pages
{
    public class HomePage
    {   
        public void GoToTMpage(IWebDriver driver)
        {

            // Navigate to Time & Material Tab

            IWebElement administrationButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationButton.Click();

            //Click on Time & Material Tab
            IWebElement timeMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterialOption.Click();
 


        }
    }
}
