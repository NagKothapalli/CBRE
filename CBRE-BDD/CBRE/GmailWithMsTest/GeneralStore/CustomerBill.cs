using GmailWithMsTest.Claculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailWithMsTest.GeneralStore
{
    [TestClass]
    public class CustomerBill
    {
        MiniCalc mCalc = new MiniCalc();
        CommercialCalc cCalc = new CommercialCalc();
        ScientificCalc sCalc = new ScientificCalc();
        Aoperations calc = new ScientificCalc();
        [TestMethod]
        public void generateCustomerBill()
        {
           long bill = calc.addition(45545, 343243);
           Debug.WriteLine("Customer Bill :" + bill);
            //mCalc.miniCalc();
            //cCalc.commercialCalc();
            //sCalc.scientificCalc();
        }
    }
}
