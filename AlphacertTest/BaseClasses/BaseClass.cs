﻿using AlphacertTest.Configuration;
using AlphacertTest.CustomException;
using AlphacertTest.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AlphacertTest.BaseClasses
{
   [TestClass]
     public class BaseClass
    {
        /// <summary>
        /// sets the chrome browser settings
        /// </summary>
        /// <returns></returns>
        private static ChromeOptions SetChromeOption() {

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            options.AddArgument("--incognito");
            return options;
        }

        /// <summary>
        /// Gets the Chrome driver 
        /// </summary>
        /// <returns></returns>
        private static IWebDriver GetChromeDriver() {

            IWebDriver driver = new ChromeDriver(SetChromeOption());
            return driver;
        }

        /// <summary>
        /// Get the Edge driver
        /// </summary>
        /// <returns></returns>
        private static IWebDriver GetEdgeDriver()
        {
            IWebDriver driver = new EdgeDriver();
            return driver;

        }

        /// <summary>
        /// Before starting the scenario sets the browser type 
        /// </summary>
        [BeforeScenario]        
        public static void InitWebdriver()
        {
            ObjectRepository.Config = new AppConfigReader();
            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;

                case BrowserType.Edge:
                    ObjectRepository.Driver = GetEdgeDriver();
                    break;
                default:
                    throw new NoSuitableDriverFound("Driver Not Found " + ObjectRepository.Config.GetBrowser());



            }
        }
    }
}
