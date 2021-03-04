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

            public static void SelectElement(IWebElement element,string name)
        {
            select = new SelectElement(element);
            select.SelectByText(name);

        }
    }
}
