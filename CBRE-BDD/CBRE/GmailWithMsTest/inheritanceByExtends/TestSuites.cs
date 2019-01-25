using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailWithMsTest.inheritanceByExtends
{
   // [TestClass]
    public class TestSuites:TestCases
    {
        //public void launchGmail()
        //{
        //    Debug.WriteLine("RC : Launch Application from TS");
        //}
        //****************Test Suites ******************
        [TestMethod]
        public void smokeTestSuite()
        {
            Debug.WriteLine("Test Suite : Smoke");
            ComposeAndSendAnEmail();
            replyToAnEmail();
        }
        [TestMethod]
        public void regressionTestSuite()
        {
            Debug.WriteLine("Test Suite : Regression");
            ComposeAndSendAnEmail();
            replyToAnEmail();
            forwardAnEmail();
            deleteAnEmail();
        }
        [TestInitialize]
        public void Preactions()
        {
            launchGmail();
            loginToGmail();
        }
        [TestCleanup]
        public void PostActions()
        {
            logoutFromGmail();
            closeGmail();
        }
    }
}
