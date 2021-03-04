using AlphacertTest.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphacertTest.ScreenShots
{
    public class SnapShot
    {

        public void TakeSnap(string imageName = "")
        {


            Screenshot ss = ((ITakesScreenshot)ObjectRepository.Driver).GetScreenshot();
            ss.SaveAsFile(GetCertificate(imageName+".jpeg"),
            ScreenshotImageFormat.Jpeg);
        }
     
        public static  string GetCertificate(string name = "")
        {
            var jsonFilePath = Path.Combine(GetCertificatePath(DateTime.UtcNow.ToString("yyyy-MM-dd")) + @"/",name);
            return jsonFilePath;
        }

        private static string GetCertificatePath(string apiType)
        {
            var assemblyPath = AppContext.BaseDirectory;
            var actualPath = assemblyPath.Substring(0, assemblyPath.LastIndexOf("bin"));
            var projectPath = new Uri(actualPath).LocalPath;
            return projectPath + @"Reports/" + apiType;
        }
    }
}
