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
using TechTalk.SpecFlow.Assist;
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
        private readonly ScenarioContext senario;
        


        public LoginSteps(ScenarioContext scenarioContext)
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
            string date = DateTime.Now.AddDays(32).ToString("dd/MM/yyyy");
            //DateTime.UtcNow.ToString("yyyy-MM-dd")
            //string date = expiryDate.ToString();
            NavigationHelper.NavigateToWebsite(ObjectRepository.Config.GetWebsite());
        }

        [Given(@"I navigate to automobile isurance")]
        public void GivenINavigateToAutomobileIsurance()
        {
            homePage.NavigateToAutomobile();
        }

      

        [Then(@"I verify the quote is sent succesfully")]
        public void ThenIVerifyTheQuoteIsSentSuccesfully()
        {                            
            validator.ValidateString("Sending e-mail success!", automobilePage.GetEmailSentText());
            snapShot.TakeSnap("EmailSent");
        }

        [Then(@"I fill the vehicle data details")]
        public void ThenIFillTheVehicleDataDetails(Table vehicledata)
        {
            var dataTableValues = vehicledata.CreateInstance<DataTables>();
           
            automobilePage.SetMake(dataTableValues.Make);
            automobilePage.SetDateOfManufacture(dataTableValues.DateOfManufacture);
            automobilePage.SetEnginePerformance(dataTableValues.EnginePerformance);
            automobilePage.SetNumberOfSeats(dataTableValues.NumberOfSeats);
            automobilePage.SetFuelType(dataTableValues.FuelType);
            automobilePage.SetListPrice(dataTableValues.ListPrice);
            automobilePage.SetLicensePlateNumber(dataTableValues.LicencePlateNumber);
            automobilePage.SetAnnualMileage(dataTableValues.AnualMilage);
            snapShot.TakeSnap("VehicleData");
            automobilePage.ClickNextButton();


        }

        [Then(@"I fill the insurance data details")]
        public void ThenIFillTheInsuranceDataDetails(Table insuranceData)
        {
            var dataTableValues = insuranceData.CreateInstance<DataTables>();

            isuranceData.SetFirstName(dataTableValues.FirstName);
            automobilePage.SetLastName(dataTableValues.LastName);
            automobilePage.SetDOB(dataTableValues.DOB);
            automobilePage.SetGenderMale();
            automobilePage.SetStreetAdress(dataTableValues.StreetAddress);
            automobilePage.SetCountry(dataTableValues.Country);
            automobilePage.SetCity(dataTableValues.City);
            automobilePage.SetOccupation(dataTableValues.Occupation);
            automobilePage.SetHobbiesSkyDiving();
            automobilePage.SetHobbiesSpeeding();
            automobilePage.SetWebsite(dataTableValues.Website);
            automobilePage.SetZipCode(dataTableValues.ZipCode);
            snapShot.TakeSnap("InsuranceData");
            automobilePage.ClickInsuranceDataNextButton();
        }

        [Then(@"I fill the enter product data details")]
        public void ThenIFillTheEnterProductDataDetails(Table productData)
        {
            var dataTableValues = productData.CreateInstance<DataTables>();
            automobilePage.SetStartDate(DateTime.Now.AddDays(32).ToString("dd/MM/yyyy"));
            automobilePage.SetInsuranceSum(dataTableValues.InsurancSum);
            automobilePage.SetMeritRating(dataTableValues.MeritRating);
            automobilePage.SetDamageInsurance(dataTableValues.DamageInsurance);
            automobilePage.SelectEuroProtection();
            automobilePage.SetCourtesuCar(dataTableValues.CourtesyCar);
            snapShot.TakeSnap("ProductData");
            automobilePage.ClickProductDataNextButton();
        }

        
        [Then(@"I select the price option")]
        public void ThenISelectThePriceOption()
        {
            WaitHelper.SetPageLoadTime(40);
            automobilePage.SelectSilverPrice();
            snapShot.TakeSnap("PriceOption");
            automobilePage.ClickSelectPriceoptionNextButton();
        }

        [Then(@"I click the send button")]
        public void ThenIClickTheSendButton()
        {
            automobilePage.ClickSendQuoteButton();
        }


        [Then(@"I fill the send qoute details")]
        public void ThenIFillTheSendQouteDetails(Table sendQuote)
        {
            var dataTableValues = sendQuote.CreateInstance<DataTables>();
            automobilePage.SetEmail(dataTableValues.Email);
            automobilePage.SetUsername(dataTableValues.Username);
            automobilePage.SetPassword(dataTableValues.Password);
            automobilePage.SetConfirmPassword(dataTableValues.ConfirmPassword);
            automobilePage.SetComments(dataTableValues.Comment);
            snapShot.TakeSnap("SendQuote");
            
        }



    }
}
