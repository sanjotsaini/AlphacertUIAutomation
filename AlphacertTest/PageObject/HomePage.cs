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

        [FindsBy(How = How.XPath, Using = "//div[@class='main-navigation']/ul/li/a[@id ='nav_automobile']")]
        private IWebElement AutomobileNavButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='main-navigation']/ul/li/a[@id ='nav_truck']")]
        private IWebElement TruckNavButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='main-navigation']/ul/li/a[@id ='nav_motorcycle']")]
        private IWebElement MoterCycleNavButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='main-navigation']/ul/li/a[@id ='nav_camper']")]
        private IWebElement CamperNavButton;

        

        #endregion

        public HomePage()
        {
            PageFactory.InitElements(ObjectRepository.Driver, this);

        }


        #region Actions
        public void QuickSearch()
        {
            

        }

        #endregion

        #region Navigation

        public void NavigateToAutomobile()
        {

            WaitHelper.SetPageLoadTime(40);
            AutomobileNavButton.Click();
            
            

        }

        public void NavigateToTruck()
        {
            TruckNavButton.Click();

        }

        public void NavigateToMotorCycle()
        {
            MoterCycleNavButton.Click();

        }

        #endregion

    }
}
