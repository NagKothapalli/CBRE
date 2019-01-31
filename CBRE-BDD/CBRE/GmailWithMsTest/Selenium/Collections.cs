using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GmailWithMsTest.Selenium
{
    [TestClass]
    public class Collections
    {
        //Modifer  DataType[]   name = {values};
        [TestMethod]
        public void staticIntegerArray()
        {
            int[] numbers = { 23, 56, 34, 4, 5, 34, 3, 67, 45, 434, 67, 334, 6, 43, 67 };
            int len = numbers.Length;
            Debug.WriteLine("Array Length :" + len);
            long val = numbers[0];
            for(int i=0;i<len;i = i+1)
            {
                Debug.WriteLine("Array elements :" + numbers[i]);
            }
            for (int i = 0; i < 16; i = i + 1)
            {
                numbers[i] = 22+i;
                Debug.WriteLine("Array elements after :" + numbers[i]);
            }

        }
        [TestMethod]
        public void dynamicIntegerArray()
        {
            //int[] numbers = { 23, 56, 34, 4, 5, 34, 3, 67, 45, 434, 67, 334, 6, 43, 67 };
            int[] numbers = new int[20];
            int len = numbers.Length;
            Debug.WriteLine("Array Length :" + len);
            long val = numbers[0];
            for (int i = 0; i < len; i = i + 1)
            {
                Debug.WriteLine("Array elements :" + numbers[i]);
            }
            for (int i = 0; i < 16; i = i + 1)
            {
                numbers[i] = 22 + i;
                Debug.WriteLine("Array elements after :" + numbers[i]);
            }

        }
        [TestMethod]
        public void dynamicStringArray()
        {
            //int[] numbers = { 23, 56, 34, 4, 5, 34, 3, 67, 45, 434, 67, 334, 6, 43, 67 };
            string[] numbers = new string[20];
            int len = numbers.Length;
            Debug.WriteLine("Array Length :" + len);
            string val = numbers[0];
            for (int i = 0; i < len; i = i + 1)
            {
                Debug.WriteLine("Array elements :" + numbers[i]);
            }
            for (int i = 0; i < 16; i = i + 1)
            {
                numbers[i] = "Selenium-" + i;
                //int+int=int,int+string=string,string+int=string,string+string=string
                Debug.WriteLine("Array elements after :" + numbers[i]);
            }

        }
        [TestMethod]
        public void GenericCollection()
        {
            //int[] numbers = { 23, 56, 34, 4, 5, 34, 3, 67, 45, 434, 67, 334, 6, 43, 67 };
            //string[] numbers = new string[20];
            ArrayList numbers = new ArrayList();
            int len = numbers.Count;
            Debug.WriteLine("Array Length brfore :" + len);
           // var val = numbers[0];
            numbers.Add(22);
            numbers.Add("Ram");
            numbers.Add('A');
            numbers.Add(true);
            Debug.WriteLine("Array Length after :" + numbers.Count);
            for (int i = 0; i < numbers.Count; i = i + 1)
            {
                Debug.WriteLine("Array elements :" + numbers[i]);
            }
        }

        [TestMethod]
        public void NonGenericCollection()
        {
            
            //int[] numbers = { 23, 56, 34, 4, 5, 34, 3, 67, 45, 434, 67, 334, 6, 43, 67 };
            //string[] numbers = new string[20];
            //ArrayList numbers = new ArrayList();
            IList<int> numbers = new List<int>();
            int len = numbers.Count;
            Debug.WriteLine("Array Length brfore :" + len);
            // var val = numbers[0];
            //numbers.Add(22);
            
            for (int i = 0; i < 15; i = i + 1)
            {
                numbers.Add(22+i);
                Debug.WriteLine("Array elements :" + numbers[i] );
            }
            Debug.WriteLine("Array Length after :" + numbers.Count);
            numbers.RemoveAt(1);
            Debug.WriteLine("Array Length after removing :" + numbers.Count);
        }
    }
}
