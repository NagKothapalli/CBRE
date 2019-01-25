using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace GmailWithMsTest.Selenium
{
    [TestClass]
    public class Gmail
    {
        IWebDriver driver;
        private ReadOnlyCollection<IWebElement> elements;

        public Gmail()
        {
            driver = new ChromeDriver();
        }
        [TestInitialize]
        public void launchGmailApplication()
        {
            
            driver.Navigate().GoToUrl("https://gmail.com");
            string sessionID = driver.CurrentWindowHandle;
            Debug.WriteLine("Window Sesion ID :" + sessionID);
            Debug.WriteLine("Current URl :" + driver.Url);
            Debug.WriteLine("Current URl :" + driver.Title);
        }
        [TestMethod]
        public void loginToGmail()
        {
          IWebElement userName =  driver.FindElement(By.Name("identifier"));
            userName.SendKeys("dfjkdsfjldlsf");
            userName.Clear();
            userName.SendKeys("nagseleniummay1");
            elements = driver.FindElements(By.CssSelector(".RveJvd"));
            SelectAnElementFromCollection(elements);
            //IWebElement element = elements[0];s
            //element.Click();
            // driver.FindElements(By.ClassName("RveJvd snByac"))[0].Click();
        }
        [TestMethod]
        public void CreateAccount()
        {
            elements = driver.FindElements(By.CssSelector(".RveJvd"));
            SelectAnElementFromCollection(elements, "Create account");
            //IWebElement element = elements[1];
            //element.Click();

        }

        public void SelectAnElementFromCollection(ReadOnlyCollection<IWebElement> elements)
        {
            for (int i = 0; i < elements.Count(); i++)
            {
                string text = elements[i].GetAttribute("innerText");
                if (text.Equals("Next"))
                {
                    elements[i].Click();
                    break;
                }
            }
        }
        public void SelectAnElementFromCollection(ReadOnlyCollection<IWebElement> elements,String attVal)
        {
            for (int i = 0; i < elements.Count(); i++)
            {
                string text = elements[i].GetAttribute("innerText");
                if (text.Equals(attVal))
                {
                    elements[i].Click();
                    break;
                }
            }
        }
    }
}
