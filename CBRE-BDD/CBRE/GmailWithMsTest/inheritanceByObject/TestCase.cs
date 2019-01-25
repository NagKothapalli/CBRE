using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailWithMsTest.inheritanceByExtends
{
    public class TestCase
    {
        ReusableComponent myRc = new ReusableComponent();
        //public void launchGmail()
        //{
        //    Debug.WriteLine("RC : Launch Application from TC");
        //}
        //*****************Test Cases ***********************************
        // [TestMethod]
        public void ComposeAndSendAnEmail()
        {
            Debug.WriteLine("Test Case : ComposeAndSendAnEmail");
            //launchGmail();
            //loginToGmail();
            myRc.compose();
            myRc.send();
            // logoutFromGmail();
            //closeGmail();

        }
       // [TestMethod]
        public void replyToAnEmail()
        {
            Debug.WriteLine("Test Case : replyToAnEmail");
            //launchGmail();
            //loginToGmail();
            myRc.open();
            myRc.reply();
            //logoutFromGmail();
            //closeGmail();

        }
       // [TestMethod]
        public void forwardAnEmail()
        {
            Debug.WriteLine("Test Case : forwardAnEmail");
            // launchGmail();
            //loginToGmail();
            myRc.open();
            myRc.forward();
            // logoutFromGmail();
            // closeGmail();

        }
       // [TestMethod]
        public void deleteAnEmail()
        {
            Debug.WriteLine("Test Case : deleteAnEmail");
            // launchGmail();
            //loginToGmail();
            myRc.open();
            myRc.delete();
            // logoutFromGmail();
            // closeGmail();

        }
    }
}
