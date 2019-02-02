using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowMsTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowMsTest.PageObjects
{
    [Binding]
    public class Hooks
    {
        static TestSetUp testSetUp;
        public static IWebDriver driver;
        public Hooks()
        {
           
        }
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("Before Test Run Hook");
            //testSetUp = new TestSetUp();
            driver = new TestSetUp().BringMyDriver();
        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("After Test Run Hook");
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.WriteLine("Before Feature Hook");
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("After Feature Hook");
        }

        [BeforeScenario (Order = 3)]
        public static void BeforeScenario1()
        {
            Console.WriteLine("Before Scenario Hook 1");
        }
        [AfterScenario]
        public static void AfterScenario1()
        {
            Console.WriteLine("After Scenario Hook 1");
        }

        

        [BeforeScenario(Order = 2)]
        public static void MyBeforeScenario2()
        {
            Console.WriteLine("Before Scenario Hook 2");
        }
        [AfterScenario]
        public static void MyAfterScenario2()
        {
            Console.WriteLine("After Scenario Hook 2");
        }
        [BeforeScenario(Order = 1)]
        public static void BeforeScenario3()
        {
            Console.WriteLine("Before Scenario Hook 3");
        }
        [AfterScenario]
        public static void AfterScenario3()
        {
            Console.WriteLine("After Scenario Hook 3");
        }



        [BeforeScenarioBlock]
        public static void BeforeScenarioBlock()
        {
            Console.WriteLine("Before Scenario Block Hook");
        }
        [AfterScenarioBlock]
        public static void AfterScenarioBlock()
        {
            Console.WriteLine("After Scenario Block Hook");
        }

        [BeforeStep]
        public static void BeforeStep()
        {
            Console.WriteLine("Before Step Hook");
        }
        [AfterStep]
        public static void AfterStep()
        {
            Console.WriteLine("After Step Hook");
        }

    }
}
