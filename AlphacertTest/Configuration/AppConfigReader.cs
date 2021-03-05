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
        /// <summary>
        /// Gets teh Browser type from App Settings
        /// </summary>
        /// <returns></returns>
        public BrowserType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get("BrowserType");
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }


        /// <summary>
        /// Gets the Webiste Url from App settings
        /// </summary>
        /// <returns></returns>
        public string GetWebsite()
        {
            return  ConfigurationManager.AppSettings.Get("WEBURL");
            
        }
    }
}
