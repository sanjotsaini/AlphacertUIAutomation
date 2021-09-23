using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AlphacertTest.FeaturesSteps
{
    [Binding]
    public class NZMuscleTestSteps
    {
        private IWebDriver _Driver;

        public NZMuscleTestSteps() {

            _Driver = new ChromeDriver();


        }

        [Given(@"I visit to NZ Muscle website")]
        public void GivenIVisitToNZMuscleWebsite()
        {
            _Driver.Navigate().GoToUrl("http://sampleapp.tricentis.com/101/index.php");
        }
        
        [When(@"I select Something")]
        public void WhenISelectSomething()
        {
            
        }
        
        [Then(@"Something is open")]
        public void ThenSomethingIsOpen()
        {
            
        }
    }
}
