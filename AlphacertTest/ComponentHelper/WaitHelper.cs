using AlphacertTest.Settings;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlphacertTest.ComponentHelper
{
  public class WaitHelper
    {
        /// <summary>
        /// Wait time if element is not found 
        /// </summary>
        /// <param name="time"></param>
        public static void ThinkTime(int time)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);            
        }


        /// <summary>
        /// Sets the wait time for page to load 
        /// </summary>
        /// <param name="time"></param>
        public static void SetPageLoadTime(int time)
        {
            ObjectRepository.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(time);
        }       

    }
}
