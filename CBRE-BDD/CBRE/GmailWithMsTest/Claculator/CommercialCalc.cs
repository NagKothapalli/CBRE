using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailWithMsTest.Claculator
{
    class CommercialCalc : Aoperations
    {
        public void commercialCalc()
        {
            Debug.WriteLine("Own method of Commercial Calc");
        }
        public int addition(int a, int b)
        {
            Debug.WriteLine("Addition from CommercialCalc");
            int sum = a + b;
            return sum;
        }

        public int division(int a, int b)
        {
            int sum = a / b;
            return sum;
        }

        public int multiplication(int a, int b)
        {
            int sum = a * b;
            return sum;
        }

        public int subtraction(int a, int b)
        {
            int sum = a - b;
            return sum;
        }
    }
}
