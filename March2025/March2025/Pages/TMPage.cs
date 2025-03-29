using March2025.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace March2025.Pages
{
    public class TMPage
    {
       

        public void CreateRecord(IWebDriver driver) 
        
        {

            //Create New Record
            IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createButton.Click();
            Wait.waitToBeVisible(driver, "Xpath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]", 5);
           
            IWebElement typeCodeOption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCodeOption.Click();

            Wait.waitToBeVisible(driver, "XPath", "//*[@id=\"TypeCode_listbox\"]/li[1]", 5); 
            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[1]"));
            materialOption.Click();

            //Enter Code
            IWebElement code = driver.FindElement(By.Id("Code"));
            code.Click();
            code.SendKeys("MARCH2025");

            //Enter Descritpion
            IWebElement descriptionText = driver.FindElement(By.Id("Description"));
            descriptionText.Click();
            descriptionText.SendKeys("Test Create New Material Record");

            //Enter Price
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();

            Wait.waitToBeClickable(driver, "Id","Price", 5);
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("100");

            //Click Save 
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
          
            Wait.waitToBeVisible(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 20);
            IWebElement lastRecordButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastRecordButton.Click();

            //Check last record of the data table
            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            //possitive path
            if (lastRecord.Text == "MARCH2025")
            {
                Console.WriteLine("New Record created succesfully");
            }
            else
            {
                Console.WriteLine("Test Failed:New Record is not created succesfully.");
            }

        }

        public void EditRecord(IWebDriver driver)

        {
            //EDIT A RECORD
            //Click on last record button

            IWebElement lastRecordButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastRecordButton.Click();

            //Click Edit in last record from the list
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();

            //Select Code
            Wait.waitToBeVisible(driver,"XPath","//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]", 5);
            IWebElement codeOption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            codeOption.Click();

            //Select Time
            Wait.waitToBeClickable(driver, "XPath", "//*[@id=\"TypeCode_listbox\"]/li[2]", 5);
            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();

            //Enter Code
            IWebElement codeText = driver.FindElement(By.Id("Code"));
            codeText.Click();
            codeText.Clear();
            codeText.SendKeys("APRIL2025");

            //Enter Description
            IWebElement descriptionText = driver.FindElement(By.Id("Description"));
            descriptionText.Click();
            descriptionText.Clear();
            descriptionText.SendKeys("Test Edit Record");

            //Enter Price
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();
            Wait.waitToBeClickable(driver, "Id", "Price", 5);

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.Clear();

            priceTag.Click();
            Thread.Sleep(1500);
            priceTextbox.SendKeys("200");

            //Click Save 
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();


            //Check if record is edited successfully
            Wait.waitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 5);
            IWebElement lastRecordButtonAfterSave = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastRecordButtonAfterSave.Click();

            //Check last record of the data table
            IWebElement lastCodeRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement lastType = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement lastDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement lastPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));

            //Happy path
            //Edit Code

            if (lastCodeRecord.Text == "APRIL2025")
            {
                Console.WriteLine("Code succesfully modified");
            }
            else
            {
                Console.WriteLine("Test Failed:Code failed to be modified.");
            }

            //Edit Type
            if (lastType.Text == "T")
            {
                Console.WriteLine("Type succesfully modified");
            }
            else
            {
                Console.WriteLine("Test Failed:Type failed to be modified.");
            }

            //Edit Description
            if (lastDescription.Text == "Test Edit Record")
            {
                Console.WriteLine("Description succesfully modified");
            }
            else
            {
                Console.WriteLine("Test Failed:Description failed to be modified.");
            }

            //Edit Price
            if (lastPrice.Text == "$200.00")
            {
                Console.WriteLine("Price succesfully modified");
            }
            else
            {
                Console.WriteLine("Test Failed:Price failed to be modified.");
            }

        }

        public void DeleteRecordTimeRecord(IWebDriver driver)

        {

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
            Wait.waitToBeVisible(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 5);

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
}
