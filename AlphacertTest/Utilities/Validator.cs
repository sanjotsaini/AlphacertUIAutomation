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
        /// <summary>
        /// This method validate the string. foe eample to get value from web page and compare it with expected value
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        public void ValidateString(string expected,string actual)
        {
            Assert.AreEqual(expected, actual);
            Assert.IsNotEmpty(actual);
            Assert.IsNotNull(actual);
        }
     
    }
}
