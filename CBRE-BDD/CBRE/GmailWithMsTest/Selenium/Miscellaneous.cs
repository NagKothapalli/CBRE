using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailWithMsTest.Selenium
{
    [TestClass]
    public class Miscellaneous
    {
        IWebDriver driver;
        public Miscellaneous()
        {
           driver = new ChromeDriver();
        }
        [TestInitialize]
        public void launchApsrtc()
        {
            driver.Navigate().GoToUrl("https://apsrtconline.in");
            //driver.Navigate().GoToUrl("http://newtours.demoaut.com/");
        }
        
        [TestMethod]
        public void WorkWithLinkTetx()
        {
            driver.FindElement(By.LinkText("Wallet")).Click();
            driver.FindElement(By.LinkText("Gallery")).Click();
        }
        [TestMethod]
        public void WorkWithPartialLinkTetx()
        {
            driver.FindElement(By.LinkText("TimeTable / Track")).Click();
            driver.FindElement(By.PartialLinkText("City Services")).Click();
        }
        [TestMethod]
        public void WorkWithStaticXpath()
        {
            driver.FindElement(By.XPath("/html/body/div[3]/div/a[8]")).Click();
        }
        [TestMethod]
        public void WorkWithRelativeXpath()
        {
            driver.FindElement(By.XPath("//a[contains(@href,'timeTable')]")).Click();
        }
        IWebElement column;
        [TestMethod]
        public void WorkWithWebTable()
        {
          IWebElement  MyTable = driver.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[2]/td[1]/table[1]/tbody/tr[3]/td/table"));
          IReadOnlyList<IWebElement>  rows = MyTable.FindElements(By.TagName("tr"));
          int  rc = rows.Count;
            Debug.WriteLine("Row Count :" + rc);
            IWebElement row = rows[0];
            IReadOnlyList<IWebElement> columns = row.FindElements(By.TagName("td"));
            int cc = columns.Count;
            Debug.WriteLine("Column Count :" + cc);
            for(int r=0;r<rc;r++)
            {
               columns =  rows[r].FindElements(By.TagName("td"));
                Debug.WriteLine("Searched : " + columns[0].GetAttribute("innerText"));
                if(columns[0].GetAttribute("innerText").Equals("Los Angeles to Chicago"))
                {
                    column = columns[1];
                    //column.Click();
                    //column.SendKeys("abcd");
                    Debug.WriteLine("Fare :" + column.GetAttribute("innerText"));
                    break;
                }

            }
        }
        [TestMethod]
        public void WorkWithWindowHandles()
        {
            driver.FindElement(By.XPath("//a[contains(@href,'timeTable')]")).Click();
            driver.FindElement(By.PartialLinkText("City Services")).Click();
            IReadOnlyCollection<string> AllWindows = driver.WindowHandles;
            for(int i=0;i<AllWindows.Count;i++)
            {
                Debug.WriteLine("SessionIDs:" + AllWindows.ElementAt(i).ToString());
            }
            Debug.WriteLine("Current window Title:" + driver.Title);
            driver.SwitchTo().Window(AllWindows.ElementAt(1));
            Debug.WriteLine("Second window Title:" + driver.Title);
            //driver.Close();
            driver.Quit();
        }

    }
}
