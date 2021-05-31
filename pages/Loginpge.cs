using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.pages
{
    class Loginpge
    {
        public void LoginSteps(IWebDriver driver)
        {

            driver.Manage().Window.Maximize();


            //enter url
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //enter username
            driver.FindElement(By.Id("UserName")).SendKeys("hari");

            //enter  password
            driver.FindElement(By.Id("Password")).SendKeys("123123");


            //click login
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Click();


            //validate the user is on the turn up page with text" Hellohari"
            string Hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a")).Text;

            if (Hellohari == "Hello hari!")
            {
                Console.WriteLine("Test passed", "Logged in sucessfully");
            }
            else
            {
                Console.WriteLine("Test failed", "login fail");
            }
        }

        }
    }

