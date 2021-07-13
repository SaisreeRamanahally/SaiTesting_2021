using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing2021.Utilities;

namespace Testing2021.pages
{
    class LoginPage

        // open chrome browser

    
           
    {
        //Functions that allows users to ligin to TP portal
        public void LoginActions(IWebDriver driver)
        {
            // open chrome browser

           

            // launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            try
            {


                // identify username textbox and enter valid username
                IWebElement username = driver.FindElement(By.Id("UserName"));
                username.SendKeys("hari");

                // identify password textbox and enter valid password
                IWebElement password = driver.FindElement(By.Id("Password"));
                password.SendKeys("123123");

                // indentify login action button and click
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }     
            
        }
    }

