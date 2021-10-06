using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace August2021.Page
{
    class TMpage
    {
        public void CreateTM(IWebDriver driver)
        {
            //click on "createNEW" button
            IWebElement CreateNewbutton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNewbutton.Click();
            //select material from "typecode" dropdown list
            IWebElement TypecodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/label"));
            TypecodeDropdown.Click();
            //Identify "material" button
            IWebElement selectmaterial = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/label"));
            selectmaterial.Click();
            //identify "code" textbox and input code
            IWebElement CodeTextbox = driver.FindElement(By.Id("Code"));
            CodeTextbox.SendKeys("see123");
            //identify "decerption" textbox and input descrption
            IWebElement descrptionTextbox = driver.FindElement(By.Id("Description"));
            descrptionTextbox.SendKeys("see123");
            //identify "price per unit" and input price per unit
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            IWebElement priceperunittextbox = driver.FindElement(By.Id("Price"));
            priceperunittextbox.SendKeys("10");
            //click on "save" button
            IWebElement savebotton = driver.FindElement(By.Id("SaveButton"));
            savebotton.Click();
            Thread.Sleep(2000);
            //assert that material record
            IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpage.Click();
            Thread.Sleep(2000);
            IWebElement materialRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1"));
            IWebElement finalmaterialRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1"));
            Thread.Sleep(1000);
            if (materialRecord.Text == "see123")
            {
                Console.WriteLine("material record created successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Test failed.");
            }
            // Assertion
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement newTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            // Assertion
            Assert.That(newCode.Text == "see123", "Actual Code and expected code do not match.");
            Assert.That(newTypeCode.Text == "m", "Actual TypeCode and expected tyecode do not match.");
            Assert.That(newDescription.Text == "see123", "Actual Description and expected description do not match.");
            Assert.That(newPrice.Text == "$10.00", "Actual Price and expected price do not match.");

            
            //option 2
           // if(materialRecord.Text == "see123")
           //{
           // Assert.Pass("materialRecord created successfully,test pass.");
           //}
           // else
           //{
           //Assert.Fail("test failed.");
           //}
           
            Thread.Sleep(2000);

        }
        public void EditTM(IWebDriver driver)
        {
            //click on "createNEW" button
            IWebElement CreateNewbutton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNewbutton.Click();
            //select material from "typecode" dropdown list
            IWebElement TypecodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/label"));
            TypecodeDropdown.Click();
            //Identify "material" button
            IWebElement selectmaterial = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/label"));
            selectmaterial.Click();
            //identify "code" textbox and input code
            IWebElement CodeTextbox = driver.FindElement(By.Id("Code"));
            CodeTextbox.SendKeys("see123");
            //identify "decerption" textbox and input descrption
            IWebElement descrptionTextbox = driver.FindElement(By.Id("Description"));
            descrptionTextbox.SendKeys("see123");
            //identify "price per unit" and input price per unit
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            IWebElement priceperunittextbox = driver.FindElement(By.Id("Price"));
            priceperunittextbox.SendKeys("10");
            //click on "save" button
            IWebElement savebotton = driver.FindElement(By.Id("SaveButton"));
            savebotton.Click();
            Thread.Sleep(2000);
            //assert that material record
            IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpage.Click();
            Thread.Sleep(2000);
            IWebElement materialRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1"));
            IWebElement finalrecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1"));





            if (materialRecord.Text == "see123")
                if (finalrecordCreated.Text == "see123")
            {
                Console.WriteLine("Time record created successfully, test passed.");
                // select Edit Button
                IWebElement Editbutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            Editbutton.Click();
            Thread.Sleep(2000);
            //select code Textbox
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.Clear();
            codeTextbox.SendKeys("123sep");
            Thread.Sleep(1000);
            //select discription
            IWebElement discription = driver.FindElement(By.Id("Description"));
            discription.Clear();
            discription.SendKeys("first material");
            //select priceperunit
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            IWebElement priceperunit = driver.FindElement(By.Id("Price"));
            priceperunit.Clear();
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            IWebElement Priceperunit = driver.FindElement(By.Id("Price"));
            priceperunit.SendKeys("15");
            Thread.Sleep(1000);
            //Select save button
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();
            Thread.Sleep(1500);
            //assert that edit material record
            IWebElement Gotolastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            Gotolastpage.Click();
            Thread.Sleep(1000);
            IWebElement materialrecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));


            Thread.Sleep(2000);
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement newTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            // Assertion
            Assert.That(newCode.Text == "123sep", "Actual Code and expected code do not match.");
            Assert.That(newTypeCode.Text == "M", "Actual TypeCode and expected tyecode do not match.");
            Assert.That(newDescription.Text == "first material", "Actual Description and expected description do not match.");
            Assert.That(newPrice.Text == "$15.00", "Actual Price and expected price do not match.");
        }
            else
            {
                Console.WriteLine("Test failed.");
                Assert.Fail("Record to be edited hasn't been found. Record not edited.");
            }

}


        public void DeleteTM(IWebDriver driver)
        {
            // select delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[6]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(5000);
            driver.SwitchTo().Alert().Accept();
            // Assert that Time record has been deleted.
            IWebElement goToLastPageBtn2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageBtn2.Click();

            IWebElement timeRecord2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]"));
            if (timeRecord2.Text != "")
            {
                Console.WriteLine("The Test is passed successfully and delete successfully.");
            }
            else
            {
                Console.WriteLine("The Test is failed.");
            }
        }
    }
}
