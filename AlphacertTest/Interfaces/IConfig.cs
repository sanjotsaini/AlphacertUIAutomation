using AlphacertTest.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphacertTest.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        string GetWebsite();
    }
}
