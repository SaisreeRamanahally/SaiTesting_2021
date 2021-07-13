using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;


namespace Testing2021.Utilities
{
    class wait
    {
        // reusable function for wait

        public static void WaitForWebElementToExist(IWebDriver driver, string attributeValue, string attribute,int secondsToWait)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, secondsToWait));
            if (attribute == "Xpath")
                
            {
               
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(attributeValue)));

            }
            if (attribute == "Id")
            {
                
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(attributeValue)));

            }
            if (attribute == "CssSelector")
            {
                
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(attributeValue)));
            }

        }

        private static void Until(Func<IWebDriver, IWebElement> func)
        {
            throw new NotImplementedException();
        }

        internal static void WaitForWebElementToExist(IWebDriver driver, string v1, object xpath, int v2)
        {
            throw new NotImplementedException();
        }

        internal static void WaitForWebElementToExist(IWebDriver driver, string v)
        {
            throw new NotImplementedException();
        }
    }
}