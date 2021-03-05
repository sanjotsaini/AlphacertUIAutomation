using AlphacertTest.ComponentHelper;
using AlphacertTest.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphacertTest.PageObject
{
    public class TruckPage
    {

        #region WebElements

        private IWebElement PayloadTxt => ObjectRepository.Driver.FindElement(By.Id("payload"));

        private IWebElement TotalWeightTxt => ObjectRepository.Driver.FindElement(By.Id("totalweight"));

        #endregion


        #region
         public void SetPayload(string value)
        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(PayloadTxt, value);
        }

        public void SetTotalWeight(string value)
        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(TotalWeightTxt, value);
        }
        #endregion

    }
}
