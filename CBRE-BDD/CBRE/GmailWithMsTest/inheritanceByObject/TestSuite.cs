using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailWithMsTest.inheritanceByExtends
{
    [TestClass]
    public class TestSuite
    {
        TestCase myTc = new TestCase();
        ReusableComponent myRc = new ReusableComponent();
        //public void launchGmail()
        //{
        //    Debug.WriteLine("RC : Launch Application from TS");
        //}
        //****************Test Suites ******************
        [TestMethod]
        public void smokeTestSuite()
        {
            Debug.WriteLine("Test Suite : Smoke");
            myTc.ComposeAndSendAnEmail();
            myTc.replyToAnEmail();
        }
        [TestMethod]
        public void regressionTestSuite()
        {
            Debug.WriteLine("Test Suite : Regression");
            myTc.ComposeAndSendAnEmail();
            myTc.replyToAnEmail();
            myTc.forwardAnEmail();
            myTc.deleteAnEmail();
        }
        [TestInitialize]
        public void Preactions()
        {
            
            myRc.launchGmail();
            myRc.loginToGmail();
        }
        [TestCleanup]
        public void PostActions()
        {
            myRc.logoutFromGmail();
            myRc.closeGmail();
        }
    }
}
