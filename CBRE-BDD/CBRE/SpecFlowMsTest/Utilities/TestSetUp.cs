using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
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
            if (ConfigurationManager.AppSettings["browser"].Equals("Chrome"))
            {
                driver = new ChromeDriver();
            }
            else if (ConfigurationManager.AppSettings["browser"].Equals("Firefox"))
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
           
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("name", ConfigurationManager.AppSettings["ApplicationName"]);
            capabilities.SetCapability(CapabilityType.BrowserName, ConfigurationManager.AppSettings["browser"]);
            capabilities.SetCapability(CapabilityType.Version, ConfigurationManager.AppSettings["BrowserVersion"]);
            capabilities.SetCapability(CapabilityType.Platform, ConfigurationManager.AppSettings["OS"]);
            capabilities.SetCapability("screen-resolution", ConfigurationManager.AppSettings["ScreenResolution"]);
            capabilities.SetCapability("username", ConfigurationManager.AppSettings["SaucelabsUserName"]);
            capabilities.SetCapability("accessKey", ConfigurationManager.AppSettings["SaucelabsAccessKey"]);
            Uri myUrl = new Uri(ConfigurationManager.AppSettings["SaucelabsURL"]);
            driver = new RemoteWebDriver(myUrl, capabilities);
            return driver;
        }
    }
}
