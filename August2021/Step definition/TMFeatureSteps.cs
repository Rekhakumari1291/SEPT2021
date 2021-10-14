using August2021.Page;
using August2021.Utilites;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace August2021.Step_definition
{
    [Binding]
    public class TMFeatureSteps : CommonDriver
    {
        TMpage tmPageObj = new TMpage();
        Homepage homePageObj = new Homepage();
        Loginpage loginPageObj = new Loginpage();

        [Given(@"I logged into turnup portal sucessfully")]
        public void GivenILoggedIntoTurnupPortalSucessfully()
        {
            // open chrome browser
            driver = new ChromeDriver();
            //login page object initialization and definition
            Loginpage loginpageObj = new Loginpage();
            loginpageObj.LoginActions(driver);

        }

        [Given(@"I nagivate to time and material pagwe")]
        public void GivenINagivateToTimeAndMaterialPagwe()
        {
            // Home page initialization and definition
            Homepage HomepageObj = new Homepage();
            HomepageObj.GoToTMPage(driver);
        }

        [When(@"I create time and material record")]
        public void WhenICreateTimeAndMaterialRecord()
        {
            //  TM page initializatio and definiion
            TMpage TMpageObj = new TMpage();
            TMpageObj.CreateTM(driver);

        }

        [Then(@"The record should be created sucessfully")]
        public void ThenTheRecordShouldBeCreatedSucessfully()
        {

            TMpage TMpageObj = new TMpage();

            string newCode = TMpageObj.GetCode(driver);
            string newTypeCode = TMpageObj.GetCode(driver);
            string newdescription = TMpageObj.Getdescription(driver);
            string newpricePerUnit = TMpageObj.Getprice(driver);


            Assert.That(newCode == "see123", "code didn't match");
            Assert.That(newTypeCode == "M", "typecode didn't match");
            Assert.That(newdescription == "see123", "Actual Description and expected Description dont match");

            Assert.That(newpricePerUnit == "$10", "Actual priceperunit and priceperunit code dont match");



            Assert.That(newCode == "see123", "code didn't match");
        }
            
    }
       
        
            }
    


