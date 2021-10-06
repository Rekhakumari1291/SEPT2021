using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace August2021.Utilites
{
    class Wait
    {
 public static void WaitForElementToBeClickable(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));


            if (locatorType == "xpath")
            {
  wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }

            if (locatorType == "id")
            {
 wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id (locatorValue)));
            }
            if (locatorType == "cssselector")
            {
 wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }
        }

        internal static void WaitForElement(IWebDriver driver, string v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
