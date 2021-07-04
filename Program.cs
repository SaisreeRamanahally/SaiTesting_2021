using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Testing2021
{
    class Program
    {
        private static object save;
        private static object price;
        private static IWebElement selectfiles;
        private static object tmsGrid;
        private static object driver;

        public static object EditButton { get; private set; }
        public static ChromeOptions Saisree { get; private set; }
        public static TimeSpan Testing { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // open chrome browser

            IWebDriver driver = new ChromeDriver("c:/Saisree/Testing/Code/Testing2021/Testing2021/");
            driver.Manage().Window.Maximize();

            // launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // identify username textbox and enter valid username
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            // identify password textbox and enter valid password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            // indentify login action button and click
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            // check if user is logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Loggedin successfully, test passed");
            }
            else
            {
                Console.WriteLine("Log in failed, test failed");
            }

            // navigate to time and material page
            Thread.Sleep(500);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
            Thread.Sleep(1500);

            // click create new button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            Thread.Sleep(1500);

            // select time from the dropdown list
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            Thread.Sleep(1500);
            driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();

            // identify code and input code
            driver.FindElement(By.Id("Code")).SendKeys("Automation");

            // identify description and input description 
            driver.FindElement(By.Id("Description")).SendKeys("Testing to see");

            // identify price per unit and input 
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            driver.FindElement(By.Id("Price")).SendKeys("60");

            // click save button
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(2500);

            // click go to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(2500);

            // check if the created record is present in the table and has expected values
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (actualCode.Text == "Automation")
            {
                Console.WriteLine("Time record created successfully, test passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }



            // Indentify  Edit action button and Click
            IWebElement EditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));

            EditButton.Click();
            Thread.Sleep(2000);


            // identify description and changes valuve in description 
            IWebElement descfield = driver.FindElement(By.Id("Description"));

            descfield.Clear();

            descfield.SendKeys("update Testing");

            Thread.Sleep(2000);


            // identify Code and changes value in Code
            IWebElement codefield = driver.FindElement(By.Id("Code"));
            codefield.Clear();

            codefield.SendKeys("saisree");

            Thread.Sleep(2000);

            //click save button
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(2500);

            // click go to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            Thread.Sleep(2500);

            IWebElement editCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            Console.WriteLine(editCode.Text);


            if (editCode.Text == "saisree")
            {
                Console.WriteLine("Time record updated successfully, test passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }



             //Indentify  Delete action button and Click

             IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));

            deleteButton.Click();

            Thread.Sleep(2500);

            driver.SwitchTo().Alert().Accept();







        }
    }
}




















