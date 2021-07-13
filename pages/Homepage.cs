using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Testing2021.Utilities;

namespace Testing2021.pages
{
    class Homepage
    {
       

        // open chrome browser
         // IWebDriver driver = new ChromeDriver("c:/Saisree/Testing/Code/Testing2021/Testing2021/");

       



        // Function to navigate TM Page
        public void GoToTMpage(IWebDriver driver)
        {

            // navigate to time and material page
            Thread.Sleep(500);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
            Thread.Sleep(1500);

        }

        internal void GoToEmployeespage(IWebDriver driver)
        {
            throw new NotImplementedException();
        }
    }
}
