using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphacertTest.ComponentHelper
{
    public class ButtonHelper
    {
        /// <summary>
        /// Clicks the the element found 
        /// </summary>
        /// <param name="element"></param>
        public static void ClickButton(IWebElement element)
        {
            element.Click();

        }
    }
}
