using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowMsTest.AppUtilities
{
    public class ApplicationUtilities
    {
        IWebElement element;
        public void SelectAnElementFromDropDown(IWebElement DropDown, int index)
        {
            new SelectElement(DropDown).SelectByIndex(index);
        }
        public void SelectAnElementFromDropDown(IWebElement DropDown, string text)
        {
            new SelectElement(DropDown).SelectByText(text);
        }
        public void SelectAnElementFromCollection(ReadOnlyCollection<IWebElement> elements)
        {
            for (int i = 0; i < elements.Count(); i++)
            {
                string text = elements[i].GetAttribute("innerText");
                if (text.Equals("Next"))
                {
                    elements[i].Click();
                    break;
                }
            }
        }
        public void SelectAnElementFromCollection(ReadOnlyCollection<IWebElement> elements, String attVal)
        {
            for (int i = 0; i < elements.Count(); i++)
            {
                string text = elements[i].GetAttribute("innerText");
                if (text.Equals(attVal))
                {
                    elements[i].Click();
                    break;
                }
            }
        }
        public void SelectAnElementFromCollection(ReadOnlyCollection<IWebElement> elements, String attType, String attVal)
        {
            for (int i = 0; i < elements.Count(); i++)
            {
                string text = elements[i].GetAttribute(attType);
                if (text.Equals(attVal))
                {
                    elements[i].Click();
                    break;
                }
            }
        }

        public IWebElement returnAnElementFromCollection(ReadOnlyCollection<IWebElement> elements, String attType, String attVal)
        {
            for (int i = 0; i < elements.Count(); i++)
            {
                string text = elements[i].GetAttribute(attType);
                if (text.Equals(attVal))
                {
                    element = elements[i];
                    break;
                }
            }
            return element;
        }
    }
}
