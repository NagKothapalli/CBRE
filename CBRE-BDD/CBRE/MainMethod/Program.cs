using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] cbre)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://gmail.com");
            Debug.WriteLine("WelCome To CBRE BDD ");
            Console.WriteLine("WelCome To CBRE BDD Console");
            //ComposeAndSendAnEmail();
            //replyToAnEmail();
            //forwardAnEmail();
            //deleteAnEmail();
            //ComposeAndSendAnEmail();
            //replyToAnEmail();
            //forwardAnEmail();
            //deleteAnEmail();
            //ComposeAndSendAnEmail();
            //replyToAnEmail();
            //forwardAnEmail();
            //deleteAnEmail();
            //ComposeAndSendAnEmail();
            //replyToAnEmail();
            //forwardAnEmail();
            //deleteAnEmail();
            //ComposeAndSendAnEmail();
            //replyToAnEmail();
            //forwardAnEmail();
            //deleteAnEmail();
        }
        //*****************Test Cases ***********************************
        private static void ComposeAndSendAnEmail()
        {
            Debug.WriteLine("Test Case : ComposeAndSendAnEmail");
            launchGmail();
            loginToGmail();
            compose();
            send();
            logoutFromGmail();
            closeGmail();

        }
        private static void replyToAnEmail()
        {
            Debug.WriteLine("Test Case : replyToAnEmail");
            launchGmail();
            loginToGmail();
            open();
            reply();
            logoutFromGmail();
            closeGmail();

        }

         static void forwardAnEmail()
        {
            Debug.WriteLine("Test Case : forwardAnEmail");
            launchGmail();
            loginToGmail();
            open();
            forward();
            logoutFromGmail();
            closeGmail();

        }

        public static void deleteAnEmail()
        {
            Debug.WriteLine("Test Case : deleteAnEmail");
            launchGmail();
            loginToGmail();
            open();
            delete();
            logoutFromGmail();
            closeGmail();

        }

        //***********************Reusable Components *******************
        public static void launchGmail()
        {
            Debug.WriteLine("RC : Launch Application");
        }
        public static void loginToGmail()
        {
            Debug.WriteLine("RC : Login Application");
        }
        public static void compose()
        {
            Debug.WriteLine("RC : Compose");
        }
        public static void send()
        {
            Debug.WriteLine("RC : Send");
        }

        public static void open()
        {
            Debug.WriteLine("RC : Open");
        }
        public static void reply()
        {
            Debug.WriteLine("RC : Reply");
        }
        public static void forward()
        {
            Debug.WriteLine("RC : Forward");
        }
        public static void delete()
        {
            Debug.WriteLine("RC : Delete");
        }
        public static void logoutFromGmail()
        {
            Debug.WriteLine("RC : Logut Application");
        }

        public static void closeGmail()
       {
            Debug.WriteLine("RC : Close Application");
        }
       
  
    }
}
