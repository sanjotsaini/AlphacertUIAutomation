using AlphacertTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphacertTest.Configuration
{

    //Reads the data from app config

    public class AppConfigReader : IConfig
    {
        public BrowserType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get("BrowserType");
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }

        public string GetWebsite()
        {
            return  ConfigurationManager.AppSettings.Get("WEBURL");
            
        }
    }
}
