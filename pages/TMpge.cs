using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Project1.pages
{
    class TMpge
    {
        public void CreateTM(IWebDriver driver)
        {
            //--------------Check if the user is able to create time/ material record successfully---------------------------------------

            //click create new record

            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            //click typecode
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();

            //click time
            driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();

            //enter code
            driver.FindElement(By.Id("Code")).SendKeys("Tc-01");


            //enter description
            driver.FindElement(By.Id("Description")).SendKeys("saving time record");


            //enter price per unit

            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("$45");

            Thread.Sleep(1000);

            //upload a file

            driver.FindElement(By.XPath("//*[@id='files']")).SendKeys(@"C:\Users\Owner\Desktop\Industry connect");

            // click save

            driver.FindElement(By.Id("SaveButton")).Click();


            //---------------- Validate the user sucessfully created the record------------------

            //click the last page in the pagination
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();

            //identify crated new record
            string actualdescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]")).Text;
            if (actualdescription == "saving time record")
            {
                Console.WriteLine("new record created", "test passed");
            }
            else
            {
                Console.WriteLine("test failed");
            }

        }

        public void EditTM(IWebDriver driver)
        {
            //----check is the user is able to edit the record----------------------------------------------

            Thread.Sleep(1000);

            //--click on the pagination to reach last record--
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();

            //click edit on the last record that was created in the previous test
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();


            //--update type code --click material
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']")).Click();

            //--update code
            driver.FindElement(By.XPath("//*[@id='Code']")).Clear();
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("updatedcode asw");

            //--update description
            driver.FindElement(By.XPath("//*[@id='Description']")).Clear();
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("updated description asw");

            //--update price per unit

            driver.FindElement(By.XPath("//*[@id='Price']")).Clear();
            driver.FindElement(By.XPath("//*[@id='Price']")).SendKeys("$222");
            //--uploadfile
            driver.FindElement(By.XPath("//*[@id='files']")).SendKeys(@"C:\Users\Owner\Desktop\Industry connect");

            //--save--
            driver.FindElement(By.Id("SaveButton")).Click();

            //-- validate the record is updated sucessfully

            //go to last page

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
            string actualUpdatedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text;
            if (actualUpdatedCode == "updatedcode asw")
            {
                Console.WriteLine("updatedcode sucessfully", "testpassed");
            }
            else
            {
                Console.WriteLine("test failed");
            }

        }

        public void DeleteTM(IWebDriver driver)
        {
            //-------------------------- Check if the user is able to delete time/ material record successfully------------------------------------------------------------------------------------
            //click delete

            IWebElement delete = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[8]/td[5]/a[2]"));
            delete.Click();

            driver.Close();
        }
    }
}
