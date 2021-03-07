using AlphacertTest.ComponentHelper;
using AlphacertTest.PageObject;
using AlphacertTest.ScreenShots;
using AlphacertTest.Settings;
using AlphacertTest.Utilities;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using static AlphacertTest.PageObject.AutomobilePage;

namespace AlphacertTest.FeaturesSteps
{
    [Binding]
    public class GenricSteps
    {
        private readonly HomePage homePage;
        private readonly AutomobilePage automobilePage;
        private readonly IsuranceData isuranceData;
        private readonly Validator validator;
        private readonly SnapShot snapShot;
        private readonly ScenarioContext _scenarioContext;

        public GenricSteps(ScenarioContext scenarioContext)
        {
            this.homePage = new HomePage();
            this.automobilePage = new AutomobilePage();
            this.isuranceData = new IsuranceData();
            this.validator = new Validator();
            this.snapShot = new SnapShot();
            this._scenarioContext = scenarioContext;
        }

        [Given(@"I visit to Tricentie website")]
        public void GivenIVisitToTricentieWebsite()
        {
            NavigationHelper.NavigateToWebsite(ObjectRepository.Config.GetWebsite());
        }

        [When(@"I fill the insurance data details")]
        public void WhenIFillTheInsuranceDataDetails(Table insuranceData)
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
            snapShot.TakeSnap(_scenarioContext.StepContext.StepInfo.Text.Replace(" ", ""));
            automobilePage.ClickInsuranceDataNextButton();
        }

        [When(@"I select the price option")]
        public void WhenISelectThePriceOption()
        {
            WaitHelper.SetPageLoadTime(40);
            automobilePage.SelectSilverPrice();
            snapShot.TakeSnap(_scenarioContext.StepContext.StepInfo.Text.Replace(" ", ""));
            automobilePage.ClickSelectPriceoptionNextButton();
        }

        [When(@"I fill the send qoute details")]
        public void WhenIFillTheSendQouteDetails(Table sendQuote)
        {
            var dataTableValues = sendQuote.CreateInstance<DataTables>();
            automobilePage.SetEmail(dataTableValues.Email);
            automobilePage.SetUsername(dataTableValues.Username);
            automobilePage.SetPassword(dataTableValues.Password);
            automobilePage.SetConfirmPassword(dataTableValues.ConfirmPassword);
            automobilePage.SetComments(dataTableValues.Comment);
            snapShot.TakeSnap(_scenarioContext.StepContext.StepInfo.Text.Replace(" ", ""));
        }

        [When(@"I click the send button")]
        public void WhenIClickTheSendButton()
        {
            automobilePage.ClickSendQuoteButton();
        }

        [Then(@"I verify the quote is sent succesfully")]
        public void ThenIVerifyTheQuoteIsSentSuccesfully()
        {
            validator.ValidateString("Sending e-mail success!", automobilePage.GetEmailSentText());
            snapShot.TakeSnap(_scenarioContext.StepContext.StepInfo.Text.Replace(" ", ""));
        }


    }
}
