using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailWithMsTest.inheritanceByExtends
{
    public class ReusableComponent
    {
        

        //***********************Reusable Components *******************
        public void launchGmail()
        {
            Debug.WriteLine("RC : Launch Application from RC");
        }
        public void loginToGmail()
        {
            Debug.WriteLine("RC : Login Application");
        }
        internal void compose()
        {
            Debug.WriteLine("RC : Compose");
        }
        internal void send()
        {
            Debug.WriteLine("RC : Send");
        }

        public void open()
        {
            Debug.WriteLine("RC : Open");
        }
        internal void reply()
        {
            Debug.WriteLine("RC : Reply");
        }
        public void forward()
        {
            Debug.WriteLine("RC : Forward");
        }
        public void delete()
        {
            Debug.WriteLine("RC : Delete");
        }
        public void logoutFromGmail()
        {
            Debug.WriteLine("RC : Logut Application");
        }

        public void closeGmail()
        {
            Debug.WriteLine("RC : Close Application");
        }

    }
}
