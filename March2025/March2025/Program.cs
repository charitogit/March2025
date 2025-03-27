
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


        ////Check if Login is successful
        //IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

        //if (hellohari.Text == "Hello hari!")
        //    {
        //    Console.WriteLine("You have logged in succesfully");
        //}
        //else
        //{
        //    Console.WriteLine("Failed to Log In");
        //}

       // Navigate to Time & Material Tab

        IWebElement administrationButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        administrationButton.Click();


        //Click on Time & Material Tab
        IWebElement timeMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        timeMaterialOption.Click();
        Thread.Sleep(1500);

        ////Create New Record
        //IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        //createButton.Click();
        //Thread.Sleep(1500);

        //IWebElement typeCodeOption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
        //typeCodeOption.Click();
        //Thread.Sleep(1500);

        ////Selecting Material Option
        //IWebElement materialOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[1]")); 
        //materialOption.Click();


        ////Enter Code
        //IWebElement code = driver.FindElement(By.Id("Code"));
        //code.Click();
        //code.SendKeys("MARCH2025");

        ////Enter Descritpion
        //IWebElement descriptionText = driver.FindElement(By.Id("Description"));
        //descriptionText.Click();
        //descriptionText.SendKeys("Test Create New Material Record");

        ////Enter Price

        //IWebElement priceTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        //priceTag.Click();

        //Thread.Sleep(1500);
        //IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
        //priceTextbox.SendKeys("100");


        ////Click Save 
        //IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        //saveButton.Click();
        //Thread.Sleep(1500);

        ////Check if Newly created record saved successfully

        //IWebElement lastRecordButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        //lastRecordButton.Click();

        ////Check last record of the data table
        //IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]")); 

        ////possitive path
        //if (lastRecord.Text == "MARCH2025")
        //{
        //    Console.WriteLine("New Record created succesfully");
        //}
        //else
        //{
        //    Console.WriteLine("Test Failed:New Record is not created succesfully.");
        //}


        ////EDIT A RECORD
        ////Click on last record button

        //IWebElement lastRecordButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")); 
        //lastRecordButton.Click();

        ////Click Edit in last record from the list
        //IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
        //editButton.Click();
        //Thread.Sleep(1500);

        ////Select Code
        //IWebElement codeOption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
        //codeOption.Click();
        //Thread.Sleep(1500);

        ////Select Time
        //IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]")); 
        //timeOption.Click();

        ////Enter Code
        //IWebElement codeText = driver.FindElement(By.Id("Code"));
        //codeText.Click();
        //codeText.Clear();
        //codeText.SendKeys("APRIL2025");

        ////Enter Description
        //IWebElement descriptionText = driver.FindElement(By.Id("Description"));
        //descriptionText.Click();
        //descriptionText.Clear();
        //descriptionText.SendKeys("Test Edit Record");

        ////Enter Price
        //IWebElement priceTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]")); 
        //priceTag.Click();
        //Thread.Sleep(1500);

        //IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
        //priceTextbox.Clear();

        //priceTag.Click();
        //Thread.Sleep(1500);
        //priceTextbox.SendKeys("200");

        ////Click Save 
        //IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        //saveButton.Click();
        //Thread.Sleep(3000);

        ////Check if record is edited successfully

        //IWebElement lastRecordButtonAfterSave = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        //lastRecordButtonAfterSave.Click();

        ////Check last record of the data table
        //IWebElement lastCodeRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
        //IWebElement lastType = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));
        //IWebElement lastDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
        //IWebElement lastPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]")); 

        ////Happy path
        ////Edit Code

        //if (lastCodeRecord.Text == "APRIL2025")
        //{
        //    Console.WriteLine("Code succesfully modified");
        //}
        //else
        //{
        //    Console.WriteLine("Test Failed:Code failed to be modified.");
        //}

        ////Edit Type
        //if (lastType.Text == "T")
        //{
        //    Console.WriteLine("Type succesfully modified");
        //}
        //else
        //{
        //    Console.WriteLine("Test Failed:Type failed to be modified.");
        //}

        ////Edit Description
        //if (lastDescription.Text == "Test Edit Record")
        //{
        //    Console.WriteLine("Description succesfully modified");
        //}
        //else
        //{
        //    Console.WriteLine("Test Failed:Description failed to be modified.");
        //}

        ////Edit Price
        //if (lastPrice.Text == "$200.00")
        //{
        //    Console.WriteLine("Price succesfully modified");
        //}
        //else
        //{
        //    Console.WriteLine("Test Failed:Price failed to be modified.");
        //}


     
        //DELETE A RECORD

        //Click on last record button
        IWebElement lastRecordButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        lastRecordButton.Click();

        //Click on Delete button for last record
        IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
        deleteButton.Click();

        //Click OK on Delete pop up
        driver.SwitchTo().Alert().Accept();

        //Check if record is deleted by going to the last record
        driver.Navigate().Refresh();

        IWebElement lastRecordButtonPostDelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")); 
        lastRecordButtonPostDelete.Click();
        Thread.Sleep(5000);

        IWebElement code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]")); 

        if (code.Text != "APRIL2025")
        {
            Console.WriteLine("Record deleted successfully.");
        }
        else
        {
            Console.WriteLine("Failed to delete record.");
        }




    }
}