using OpenQA.Selenium;
using SpecFlowMsTest.AppUtilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;

namespace SpecFlowMsTest.PageObjects
{
    public class Compose
    {
        IWebDriver driver = Hooks.driver;
        ApplicationUtilities appUtils;
        private ReadOnlyCollection<IWebElement> elements;

        public Compose()
        {
            driver = Hooks.driver;
            appUtils = new ApplicationUtilities();
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "txtEmail")]        private IWebElement EmailAddress { get; set; }
        public void LaunchApplication()
        {
            Console.WriteLine("Launch Application");
            //driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
        }

        public void LoginApplication()
        {
            Console.WriteLine("Login To Application");
            //driver.FindElement(By.Name("identifier")).SendKeys(ConfigurationManager.AppSettings["UserName"]);
            //elements = driver.FindElements(By.CssSelector(".RveJvd"));
            //appUtils.returnAnElementFromCollection(elements, "innerText", "Next").Click();
            //Thread.Sleep(2000);
            //driver.FindElement(By.Name("password")).SendKeys(ConfigurationManager.AppSettings["PassWord"]);
            //elements = driver.FindElements(By.CssSelector(".RveJvd"));
            //appUtils.returnAnElementFromCollection(elements, "innerText", "Next").Click();
        }
        public void ComposeMail()
        {
            Console.WriteLine("Compose Email");
        }
        public void ComposeMailWithOutAttachment()
        {
            Console.WriteLine("Compose Email WithOut Attachment");
        }
        public void SendMail()
        {
            Console.WriteLine("Send Email");
        }
        public void ValidateEmail()
        {
            Console.WriteLine("Validate Email is Sent Successfully");
        }
    }
}
