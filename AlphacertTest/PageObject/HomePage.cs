using AlphacertTest.ComponentHelper;
using AlphacertTest.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphacertTest.PageObject
{
   public  class HomePage
    {

        #region WebElements

        
        private IWebElement AutomobileNavButton => ObjectRepository.Driver.FindElement(By.XPath("//div[@class='main-navigation']/ul/li/a[@id ='nav_automobile']"));
        
        private IWebElement TruckNavButton =>  ObjectRepository.Driver.FindElement(By.XPath("//div[@class='main-navigation']/ul/li/a[@id ='nav_truck']"));
        
        private IWebElement MoterCycleNavButton => ObjectRepository.Driver.FindElement(By.XPath("//div[@class='main-navigation']/ul/li/a[@id ='nav_motorcycle']"));
        
        private IWebElement CamperNavButton => ObjectRepository.Driver.FindElement(By.XPath("//div[@class='main-navigation']/ul/li/a[@id ='nav_camper']"));



        #endregion

            

       

        #region Navigation

        public void NavigateToAutomobile()
        {
            WaitHelper.SetPageLoadTime(40);
            AutomobileNavButton.Click();                       
        }

        public void NavigateToTruck()
        {
            WaitHelper.SetPageLoadTime(40);
            TruckNavButton.Click();
        }

        public void NavigateToMotorCycle()
        {
            WaitHelper.SetPageLoadTime(40);
            MoterCycleNavButton.Click();
        }
        public void NavigateToCamper()
        {
            WaitHelper.SetPageLoadTime(40);
            CamperNavButton.Click();
        }

        #endregion

    }
}
