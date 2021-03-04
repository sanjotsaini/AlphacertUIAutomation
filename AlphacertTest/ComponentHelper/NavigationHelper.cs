using AlphacertTest.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphacertTest.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToWebsite(string Url)
        {
            WaitHelper.SetPageLoadTime(50000);
            WaitHelper.ThinkTime(5);
            //ObjectRepository.Driver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromMilliseconds(1));
            ObjectRepository.Driver.Navigate().GoToUrl(Url);
             
        }

    }
}
