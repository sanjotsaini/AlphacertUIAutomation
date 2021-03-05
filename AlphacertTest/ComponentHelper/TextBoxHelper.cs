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
        /// <summary>
        /// Enters the value in teh text box
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void setTextBoxValue(IWebElement element, string value)
        {
            element.SendKeys(value);

        }

        /// <summary>
        /// Get the Value of Text Box
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static string GetTextBoxValue(IWebElement element)
        {
            return element.Text;

        }
    }
}
