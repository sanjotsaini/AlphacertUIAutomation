using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphacertTest.ComponentHelper
{
    public class TextBoxHelper
    {

        public static void setTextBoxValue(IWebElement element, string value)
        {
            element.SendKeys(value);

        }


        public static string GetTextBoxValue(IWebElement element)
        {
            return element.Text;

        }
    }
}
