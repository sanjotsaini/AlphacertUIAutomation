using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphacertTest.Utilities
{
    public class Validator
    {

        public void ValidateString(string expected,string actual)
        {
            Assert.AreEqual(expected, actual);
            Assert.IsNotEmpty(actual);
            Assert.IsNotNull(actual);


        }

        public string GetCertificate(string name)
        {
            var jsonFilePath = Path.Combine(GetCertificatePath("CRMFacade") + @"/", name);
            return jsonFilePath;
        }

        private string GetCertificatePath(string apiType)
        {
            var assemblyPath = AppContext.BaseDirectory;
            var actualPath = assemblyPath.Substring(0, assemblyPath.LastIndexOf("bin"));
            var projectPath = new Uri(actualPath).LocalPath;
            return projectPath + @"ScreenShots/" + apiType;
        }
    }
}
