using March2025.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace March2025.Pages
{
    public class LogInPage
    {
        public void LoginSteps(IWebDriver driver)
        {

            //Identify the UserName textbox and Enter User Name
            IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));
            userNameTextBox.SendKeys("hari");

            //Identify the Password textbox and Enter Password
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");

            //Click on the LogIn Button
            IWebElement logInButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            logInButton.Click();



            //Check if Login is successful
            Wait.waitToBeVisible(driver, "XPath", "//*[@id=\"logoutForm\"]/ul/li/a", 5); 
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

            if (hellohari.Text == "Hello hari!")
            {
                Console.WriteLine("You have logged in succesfully");
            }
            else
            {
                Console.WriteLine("Failed to Log In");
            }

        }
    }
}
