
using March2025.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


public class Program
{
  
    private static void Main(string[] args)
    {
   
        //Initialize and Open  the chrome browser
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();

        //Launch the TurnUp Portal Site
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

        //Login
        LogInPage loginPageObj = new LogInPage();
        loginPageObj.LoginSteps(driver);

        //Navigate to Time & Material Page via Administration tab
        HomePage homePageObj = new HomePage();
        homePageObj.GoToTMpage(driver);

        //Prepare to call TimeMaterial Page
        TMPage  tmPageObj = new TMPage();

        //Create new record
        tmPageObj.CreateRecord(driver);

        //Edit record
       // tmPageObj.EditRecord(driver);

        //Delete Record
        //tmPageObj.DeleteRecordTimeRecord(driver);


    }
}