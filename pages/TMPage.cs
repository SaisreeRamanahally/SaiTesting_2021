using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Testing2021.Utilities;

namespace Testing2021.pages
{
    class TMPage
    {


        // Test Create new TM
        public void CreateTM(IWebDriver driver)
        {
            // click create new button
            IWebElement createnew = (IWebElement)driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createnew.Click();
            wait.WaitForWebElementToExist(driver, "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]", "Xpath",5);

            // select time from the dropdown list
            // driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            // Thread.Sleep(1500);
            //driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();

            // identify code and input code

            IWebElement code = (IWebElement)driver.FindElement(By.Id("Code"));
            code.SendKeys("z1234");



            // identify description and input description 
            IWebElement description = (IWebElement)driver.FindElement(By.Id("Description"));
            description.SendKeys("asdef");



            // identify price per unit and input 

            IWebElement priceperunit = (IWebElement)driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceperunit.SendKeys("60");



            // click save button
            IWebElement savebutton = (IWebElement)driver.FindElement(By.Id("SaveButton"));
            savebutton.Click();
            Thread.Sleep(2500);

            // click go to last page
            IWebElement lastpage = (IWebElement)driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpage.Click();
            Thread.Sleep(2500);
            // check if the created record is present in the table and has expected values
            IWebElement actualCode = (IWebElement)driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (actualCode.Text == "Automation")
            {
                Console.WriteLine("Time record created successfully, test passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
        }


        // Test EditTM

        public void EditTM(IWebDriver driver)
        {


            // Indentify  Edit action button and Click
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();
            
            
            Thread.Sleep(2000);


            // identify description and changes valuve in description 
            IWebElement descfield = (IWebElement)driver.FindElement(By.Id("Description"));

            descfield.Clear();

            descfield.SendKeys("update Testing");

            Thread.Sleep(2000);


            // identify Code and changes value in Code
            IWebElement codefield = (IWebElement)driver.FindElement(By.Id("Code"));
            codefield.Clear();

            codefield.SendKeys("saisree");

            Thread.Sleep(2000);

            //click save button
            IWebElement savebutton = (IWebElement)driver.FindElement(By.Id("SaveButton"));
            savebutton.Click();
            Thread.Sleep(2500);

            // click go to last page
            IWebElement lastpage = (IWebElement)driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpage.Click();
            Thread.Sleep(2500);

            IWebElement editCode = (IWebElement)driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            Console.WriteLine(editCode.Text);
            if (editCode.Text == "saisree")
            {
                Assert.Pass("Time record updated successfully, test passed");
            }
            else
            {
                Assert.Fail("Test Failed");
            }


        }

       // Test DeleteTM

        public void DeleteTM(IWebDriver driver)
        {

            //Indentify  Delete action button and Click

            IWebElement delete = (IWebElement)driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[5]/a[2]"));
            delete.Click();

            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(2000);





            IWebElement lastpage = (IWebElement)driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastpage.Click();
            Thread.Sleep(2500);
            IWebElement actualcode = (IWebElement)driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            //object actualcode = null;

            Console.WriteLine("Test pass");

            if (actualcode.Text == "testing to see")
            {
                Console.WriteLine("test fail");
            }


            else
            {
                Console.WriteLine(" Record deleted succfully ; test pass");

            }

        
        }
      
    }
}
