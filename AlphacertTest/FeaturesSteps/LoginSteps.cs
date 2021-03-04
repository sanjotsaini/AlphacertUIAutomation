using AlphacertTest.BaseClasses;
using AlphacertTest.ComponentHelper;
using AlphacertTest.Configuration;
using AlphacertTest.Interfaces;
using AlphacertTest.PageObject;
using AlphacertTest.ScreenShots;
using AlphacertTest.Settings;
using AlphacertTest.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
//using System.Configuration;
using TechTalk.SpecFlow;
using static AlphacertTest.PageObject.AutomobilePage;

namespace AlphacertTest.FeaturesSteps
{
    [Binding]
    public sealed class LoginSteps 
    {
        private readonly HomePage homePage;
        private readonly AutomobilePage automobilePage;
        private readonly IsuranceData isuranceData;
        private readonly Validator validator;
        private readonly SnapShot snapShot;

       
        public LoginSteps()
        {
            this.homePage = new HomePage();
            this.automobilePage = new AutomobilePage();
            this.isuranceData = new IsuranceData();
            this.validator = new Validator();
            this.snapShot = new SnapShot();
        }        

        [Given(@"I visit to Tricentie website")]
        public void GivenIVisitToTricentieWebsite()
        {
            NavigationHelper.NavigateToWebsite(ObjectRepository.Config.GetWebsite());
        }

        [Given(@"I navigate to automobile isurance")]
        public void GivenINavigateToAutomobileIsurance()
        {
            homePage.NavigateToAutomobile();
        }

        [When(@"I filled the required details and send teh quote")]
        public void WhenIFilledTheRequiredDetailsAndSendTehQuote()
        {
            automobilePage.SetMake("BMW");
            automobilePage.SetDateOfManufacture("02/04/2007");
            automobilePage.SetEnginePerformance("236");
            automobilePage.SetNumberOfSeats("5");
            automobilePage.SetFuelType("Petrol");
            automobilePage.SetListPrice("50000");
            automobilePage.SetLicensePlateNumber("LSU335");
            automobilePage.SetAnnualMileage("300");
            snapShot.TakeSnap("EnterVehicleData");
            automobilePage.ClickNextButton();
            isuranceData.SetFirstName("Sanjot");
            automobilePage.SetLastName("Saini");
            automobilePage.SetDOB("12/26/1993");
            automobilePage.SetGenderMale();
            automobilePage.SetStreetAdress("23, Magnolia Drive, Westown");
            automobilePage.SetCountry("New Zealand");
            automobilePage.SetCity("New Plymouth");
            automobilePage.SetOccupation("Farmer");
            automobilePage.SetHobbiesSkyDiving();
            automobilePage.SetHobbiesSpeeding();
            automobilePage.SetWebsite("https://facebook.com");
            automobilePage.SetZipCode("4310");
            snapShot.TakeSnap("InsuranceData");
            automobilePage.ClickInsuranceDataNextButton();
            automobilePage.SetStartDate("04/05/2021");
            automobilePage.SetInsuranceSum("7.000.000,00");
            automobilePage.SetMeritRating("Bonus 7");
            automobilePage.SetDamageInsurance("Full Coverage");
            automobilePage.SelectEuroProtection();
            automobilePage.SetCourtesuCar("Yes");
            snapShot.TakeSnap("ProductData");
            automobilePage.ClickProductDataNextButton();
            WaitHelper.SetPageLoadTime(40);
            automobilePage.SelectSilverPrice();
            snapShot.TakeSnap("PriceOption");
            automobilePage.ClickSelectPriceoptionNextButton();
            automobilePage.SetEmail("Sainisanjot26@gmail.com");
            automobilePage.SetUsername("Sainisa");
            automobilePage.SetPassword("Password@123");
            automobilePage.SetConfirmPassword("Password@123");
            automobilePage.SetComments("Testing Exam");
            snapShot.TakeSnap("SendQuote");
            automobilePage.ClickSendQuoteButton();
        }

        [Then(@"I verify the quote is sent succesfully")]
        public void ThenIVerifyTheQuoteIsSentSuccesfully()
        {
            
                
            validator.ValidateString("Sending e-mail success!", automobilePage.GetEmailSentText());
            snapShot.TakeSnap("EmailSent");



        }

    }
}
