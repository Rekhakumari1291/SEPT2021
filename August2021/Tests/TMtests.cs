using August2021.Page;
using August2021.Utilites;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace August2021.Tests
{
    [TestFixture]
    class TMtests : CommonDriver

    {
        [SetUp]
        public void LoginActions()
        {
            // open chrome browser
            driver = new ChromeDriver();
            //login page object initialization and definition
            Loginpage loginpageObj = new Loginpage();
            loginpageObj.LoginActions(driver);

            // Home page initialization and definition
            Homepage HomepageObj = new Homepage();
            HomepageObj.GoToTMPage(driver);
        }
        
        [Test,Order(1)]
        public void CreateTMTest()
        {
            // TM page initializatio and definiion
            TMpage TMpageObj = new TMpage();
            TMpageObj.CreateTM(driver);

        }
        [Test,Order(2)]
        public void EditTMTest()

        {
            //Edit
            TMpage TMpageObj = new TMpage();
            TMpageObj.EditTM(driver);

        }
        [Test,Order(3)]
        //Delete
        public void DeleteTMTest()
        {
            TMpage TMpageObj = new TMpage();
            TMpageObj.DeleteTM(driver);
        }
        [TearDown]
        public void closeTestRun()
        {



        }
    }
}

    
    

