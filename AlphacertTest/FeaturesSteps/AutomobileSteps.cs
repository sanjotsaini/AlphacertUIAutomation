using AlphacertTest.PageObject;
using AlphacertTest.ScreenShots;
using AlphacertTest.Utilities;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using static AlphacertTest.PageObject.AutomobilePage;

namespace AlphacertTest.FeaturesSteps
{
    [Binding]
    public class AutomobileSteps
    {

        private readonly HomePage homePage;
        private readonly AutomobilePage automobilePage;
        private readonly IsuranceData isuranceData;
        private readonly Validator validator;
        private readonly SnapShot snapShot;
        private readonly ScenarioContext _scenarioContext;


        public AutomobileSteps(ScenarioContext scenarioContext)
        {
            this.homePage = new HomePage();
            this.automobilePage = new AutomobilePage();
            this.isuranceData = new IsuranceData();
            this.validator = new Validator();
            this.snapShot = new SnapShot();
            _scenarioContext = scenarioContext;
        }

        [When(@"I navigate to automobile insurance")]
        public void WhenINavigateToAutomobileInsurance()
        {
            homePage.NavigateToAutomobile();
        }
        
        [When(@"I fill the vehicle data details automobile")]
        public void WhenIFillTheVehicleDataDetailsAutomobile(Table AutomobileVehicledata)
        {
            var dataTableValues = AutomobileVehicledata.CreateInstance<DataTables>();
            automobilePage.SetMake(dataTableValues.Make);
            automobilePage.SetDateOfManufacture(dataTableValues.DateOfManufacture);
            automobilePage.SetEnginePerformance(dataTableValues.EnginePerformance);
            automobilePage.SetNumberOfSeats(dataTableValues.NumberOfSeats);
            automobilePage.SetFuelType(dataTableValues.FuelType);
            automobilePage.SetListPrice(dataTableValues.ListPrice);
            automobilePage.SetLicensePlateNumber(dataTableValues.LicencePlateNumber);
            automobilePage.SetAnnualMileage(dataTableValues.AnualMilage);            
            snapShot.TakeSnap(_scenarioContext.StepContext.StepInfo.Text.Replace(" ", ""));
            automobilePage.ClickNextButton();
        }
        
        [When(@"I fill the enter product data details for automobile")]
        public void WhenIFillTheEnterProductDataDetailsForAutomobile(Table automobileProductData)
        {
            var dataTableValues = automobileProductData.CreateInstance<DataTables>();
            automobilePage.SetStartDate(DateTime.Parse(dataTableValues.StartDate).AddDays(80).ToString("MM/dd/yyyy"));
            automobilePage.SetInsuranceSum(dataTableValues.InsurancSum);
            automobilePage.SetMeritRating(dataTableValues.MeritRating);
            automobilePage.SetDamageInsurance(dataTableValues.DamageInsurance);
            automobilePage.SelectEuroProtection();
            automobilePage.SetCourtesuCar(dataTableValues.CourtesyCar);
            snapShot.TakeSnap(_scenarioContext.StepContext.StepInfo.Text.Replace(" ", ""));
            automobilePage.ClickProductDataNextButton();
        }
    }
}
