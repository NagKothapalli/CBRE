using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailWithMsTest.Claculator
{
    class MiniCalc:Aoperations
    {
        public void miniCalc()
        {
            Debug.WriteLine("Own method of MiniCalc");
        }
        public int addition(int a,int b)
        {
            Debug.WriteLine("Addition from MiniCalc");
            return a + b;
        }
        public int subtraction(int a, int b)
        {
            return a - b;
        }
        public int multiplication(int a, int b)
        {
            return a * b;
        }
        public int division(int a, int b)
        {
            return a - b;
        }
    }
}
