using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Project1.pages;
using Project1.utilities;
using System;
using System.Threading;

namespace Project1
{
    [TestFixture]
    class Program : Commondriver
    {
       
            [SetUp]
            public void LoginTurnUp()
            {
            //launch chrome browser

            driver = new ChromeDriver(@"C:\Users\Owner\Desktop\Industry connect\may2021");

                //create object for login pagfe

                Loginpge loginobj = new Loginpge();
                loginobj.LoginSteps(driver);

                HomePge Homeobj = new HomePge();
                Homeobj.NavigatetoTm(driver);

            }
            [Test]
            public void CreateTmTest()
            {
                TMpge Tmobj = new TMpge();
            Tmobj.CreateTM(driver);

            }
            [Test]
            public void EditTmTest()
            {
                TMpge Tmobj = new TMpge();

                Tmobj.EditTM(driver);

            }
            [Test]
            public void DeleteTmTest()
            {
                TMpge Tmobj = new TMpge();
                Tmobj.DeleteTM(driver);
            }

            [TearDown]
            public void TestClosure()
            {
                TMpge Tmobj = new TMpge();

            }

        }
    } 
