using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using Testing2021.pages;
using Testing2021.Utilities;

namespace Testing2021
{
    [TestFixture]
    class Program : Commondriver
    {


            [SetUp]
            public void LoginSteps()
            {

            // chrome driver
            driver = new ChromeDriver("c:/Saisree/Testing/Code/Testing2021/Testing2021/");
            LoginPage loginObj = new LoginPage();
            loginObj.LoginActions(driver);

            Homepage homePageObj = new Homepage();
            homePageObj.GoToTMpage(driver);

            }
            
        
            [Test]
            public void CreateTMTest()
            {
                // object for TM page

                TMPage tmobj = new TMPage();

                tmobj.CreateTM(driver);


            }

        
            [Test]
            public void EditTMTest()
            {
                // object TM page
                TMPage tmobj = new TMPage();
                tmobj.EditTM(driver);

            }
        
           
            [Test]
            public void DeleteTMTest()
            {
                // object TM page

                TMPage tmobj = new TMPage();
                tmobj.DeleteTM(driver);

            } 
               
        [TearDown]
            public void CloseTestRun()
            {


            }
 
    }

  
}


















