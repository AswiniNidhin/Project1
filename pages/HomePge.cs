using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.pages
{
    class HomePge
    { public void NavigatetoTm(IWebDriver driver)
        {
            //click administration 
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            //click time and material
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();

        }
    }
}
