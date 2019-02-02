using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowMsTest.Utilities
{
    public class TestSetUp
    {
        IWebDriver driver;
        public IWebDriver BringMyDriver()
        {
            if(ConfigurationManager.AppSettings["ExecutionType"].Equals("Local"))
            {
                driver = BringMyLocalDriver();
            }
            else if (ConfigurationManager.AppSettings["ExecutionType"].Equals("Remote"))
            {
                driver = BringMyRemoteDriver();
            }
            else
            {
                driver = BringMyLocalDriver();
            }
            return driver;
        }

        public IWebDriver BringMyLocalDriver()
        {
            if (ConfigurationManager.AppSettings["Browser"].Equals("Chrome"))
            {
                driver = new ChromeDriver();
            }
            else if (ConfigurationManager.AppSettings["Browser"].Equals("Firefox"))
            {
                driver = new FirefoxDriver();
            }
            else
            {
                driver = new ChromeDriver();
            }
            return driver;
        }

        public IWebDriver BringMyRemoteDriver()
        {
            return driver;
        }
    }
}
