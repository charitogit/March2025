
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


public class Program
{

    private static void Main(string[] args)
    {
   
        //Initialize and Opent  the chrome browser
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();


        //Launch the TurnUp Portal Site
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

        //Identify the UserName textbox and Enter User Name
        IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));
        userNameTextBox.SendKeys("hari");

        //Identify the Password textbox and Enter Password
        IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
        passwordTextBox.SendKeys("123123");

        //Click on the LogIn Button
        IWebElement logInButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        logInButton.Click();
        Thread.Sleep(1500);




        //Check if Login is successful


        IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
        
        if (hellohari.Text == "Hello hari!")
            {
            Console.WriteLine("You have logged in succesfully");
        }
        else
        {
            Console.WriteLine("Failed to Log In");
        }

        driver.Quit();
    }
}