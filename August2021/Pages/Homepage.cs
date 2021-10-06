using August2021.Utilites;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace August2021.Page
{
    class Homepage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            //click on administration
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a "));
            administration.Click();
            Wait.WaitForElementToBeClickable(driver,"XPath ","/ html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a", 3);
            //select on time & material
            IWebElement TMdropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TMdropdown.Click();
            
        }
    }
}
