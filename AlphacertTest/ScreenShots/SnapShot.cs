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
        /// <summary>
        /// this method take the screen shot of window
        /// </summary>
        /// <param name="imageName"></param>         
        public void TakeSnap(string imageName = "")
        {

            string path = GetPath(imageName + ".jpeg");
            Screenshot ss = ((ITakesScreenshot)ObjectRepository.Driver).GetScreenshot();
            ss.SaveAsFile(GetPath(imageName+".jpeg"),
            ScreenshotImageFormat.Jpeg);
        }
     
        public static  string GetPath(string name = "")
        {
            var jsonFilePath = Path.Combine(GetProjectPath(DateTime.UtcNow.ToString("yyyy-MM-dd")) + @"/",name);
            return jsonFilePath;
        }

        private static string GetProjectPath(string apiType)
        {
            var assemblyPath = AppContext.BaseDirectory;
            var actualPath = assemblyPath.Substring(0, assemblyPath.LastIndexOf("bin"));
            var projectPath = new Uri(actualPath).LocalPath;
            return projectPath + @"Reports/" + apiType;

        }
    }
}
