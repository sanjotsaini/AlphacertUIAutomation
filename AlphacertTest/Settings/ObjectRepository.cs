using AlphacertTest.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphacertTest.Settings
{
    // this classw ith conating object and proprty used y other classes in Framework 

    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get;set; }
    }
}
