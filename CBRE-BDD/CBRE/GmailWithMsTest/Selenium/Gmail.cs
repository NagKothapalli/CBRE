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
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using OpenQA.Selenium.Interactions;

namespace GmailWithMsTest.Selenium
{
    [TestClass]
    public class Gmail
    {

        IWebDriver driver;
        private ReadOnlyCollection<IWebElement> elements;
        private IWebElement btnContainer;
        IWebElement element;
        Actions myActions;
        public Gmail()
        {
            driver = new ChromeDriver();
            myActions = new Actions(driver);
            
        }
        [TestInitialize]
        public void launchGmailApplication()
        {
            var url =  ConfigurationManager.AppSettings["URL"];
            //driver.Navigate().GoToUrl("https://gmail.com");
            driver.Navigate().GoToUrl("https://staging99.arbella.com");
            //driver.Navigate().GoToUrl("http://newtours.demoaut.com");
            //driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
            string sessionID = driver.CurrentWindowHandle;
            Debug.WriteLine("Window Sesion ID :" + sessionID);
            Debug.WriteLine("Current URl :" + driver.Url);
            Debug.WriteLine("Current URl :" + driver.Title);
        }
        [TestMethod]
        public void WorkWithActions()
        {
          IWebElement UserNameObj =  driver.FindElement(By.Name("username"));
            myActions.MoveToElement(UserNameObj).ContextClick().Build().Perform();
            myActions.MoveToElement(UserNameObj).DoubleClick().Build().Perform();
            myActions.MoveToElement(UserNameObj).Click().SendKeys("Cigniti").SendKeys(Keys.Tab).SendKeys("Arb3lla01").SendKeys(Keys.Tab).SendKeys(Keys.Enter).Build().Perform();
        }
        [TestMethod]
        public void loginToArbella_Submit()
        {
            EnterUserDetails(ConfigurationManager.AppSettings["UserName"], ConfigurationManager.AppSettings["PassWord"]);
            //EnterUserDetails("Cigniti", "Arb3lla01");
            SubmitContainer("Submit");
            //btnContainer =  driver.FindElement(By.Id("buttonContainer"));
            //elements = btnContainer.FindElements(By.TagName("input"));
            //SelectAnElementFromCollection(elements, "value", "Submit");
        }
        [TestMethod]
        public void loginToArbella_Cancel()
        {
            EnterUserDetails("Cigniti", "Arb3lla01");
            SubmitContainer("Cancel");
            //btnContainer = driver.FindElement(By.Id("buttonContainer"));
            //elements = btnContainer.FindElements(By.TagName("input"));
            //SelectAnElementFromCollection(elements, "value", "Cancel");
        }
        [TestMethod]
        public void loginToArbella_Help()
        {
            EnterUserDetails("Cigniti", "Arb3lla01");
            SubmitContainer("Help");
            //btnContainer = driver.FindElement(By.Id("buttonContainer"));
            //elements = btnContainer.FindElements(By.TagName("input"));
            //SelectAnElementFromCollection(elements, "value", "Cancel");
        }
        [TestMethod]
        public void MouseOver()
        {
            loginToArbella_Submit();
            IWebElement Reports = driver.FindElement(By.Id("ulaitem0z5"));
            Actions myActions = new Actions(driver);
            myActions.MoveToElement(Reports).Build().Perform();
        }
        [TestMethod]
        public void CreateQuote_HomeOwners()
        {
            loginToArbella_Submit();
            SelectAnElementFromDropDown(driver.FindElement(By.Id("plNewBizSelect")),1);
            //IWebElement NewBizObj = driver.FindElement(By.Id("plNewBizSelect"));
            //SelectElement MyDropDown = new SelectElement(NewBizObj);
            //MyDropDown.SelectByIndex(1);
            //******************

            //SelectElement MyDropDown = new SelectElement(driver.FindElement(By.Id("plNewBizSelect")));
            //MyDropDown.SelectByIndex(1);

            //new SelectElement(driver.FindElement(By.Id("plNewBizSelect"))).SelectByText("Homeowners");

            //***********
            //MyDropDown.SelectByText("Homeowners");
            //Thread.Sleep(1000);
            //MyDropDown.SelectByText("Personal Auto");
        }
        public void SelectAnElementFromDropDown(IWebElement DropDown,int index)
        {
            new SelectElement(DropDown).SelectByIndex(index);
        }
        public void SelectAnElementFromDropDown(IWebElement DropDown, string text)
        {
            new SelectElement(DropDown).SelectByText(text);
        }
        public void EnterUserDetails(String un,String pw)
        {
            driver.FindElement(By.Name("username")).SendKeys(un);
            driver.FindElement(By.Name("password")).SendKeys(pw);
        }
        public void SubmitContainer(String btn)
        {
            btnContainer = driver.FindElement(By.Id("buttonContainer"));
            elements = btnContainer.FindElements(By.TagName("input"));
            returnAnElementFromCollection(elements, "value", btn).Click();
        }
        [TestMethod]
        public void loginToGmail()
        {
          IWebElement userName =  driver.FindElement(By.Name("identifier"));
            userName.SendKeys("dfjkdsfjldlsf");
            userName.Clear();
            userName.SendKeys("nagseleniummay1");
            elements = driver.FindElements(By.CssSelector(".RveJvd"));
            returnAnElementFromCollection(elements, "innerText", "Next").Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("password")).SendKeys("kothapalli@1234");
            elements = driver.FindElements(By.CssSelector(".RveJvd"));
            returnAnElementFromCollection(elements, "innerText", "Next").Click();
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
        public void SelectAnElementFromCollection(ReadOnlyCollection<IWebElement> elements, String attType,String attVal)
        {
            for (int i = 0; i < elements.Count(); i++)
            {
                string text = elements[i].GetAttribute(attType);
                if (text.Equals(attVal))
                {
                    elements[i].Click();
                    break;
                }
            }
        }

        public IWebElement returnAnElementFromCollection(ReadOnlyCollection<IWebElement> elements, String attType, String attVal)
        {
            for (int i = 0; i < elements.Count(); i++)
            {
                string text = elements[i].GetAttribute(attType);
                if (text.Equals(attVal))
                {
                    element = elements[i];
                    break;
                }
            }
            return element;
        }
    }
}
