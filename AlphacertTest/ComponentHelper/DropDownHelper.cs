using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphacertTest.ComponentHelper
{
   public class DropDownHelper
    {
        private static SelectElement select;
        /// <summary>
        /// Select the value from drop down with name 
        /// </summary>
        /// <param name="element"></param>
        /// <param name="name"></param>
            public static void SelectElement(IWebElement element,string name)
        {
            select = new SelectElement(element);
            select.SelectByText(name);

        }
    }
}
