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

        public AutomobileSteps(ScenarioContext scenarioContext)
        {
            this.homePage = new HomePage();
            this.automobilePage = new AutomobilePage();
            this.isuranceData = new IsuranceData();
            this.validator = new Validator();
            this.snapShot = new SnapShot();
        }

        [Given(@"I navigate to automobile insurance")]
        public void GivenINavigateToAutomobileInsurance()
        {
            homePage.NavigateToAutomobile();
        }


        [Then(@"I fill the vehicle data details automobile")]
        public void ThenIFillTheVehicleDataDetailsAutomobile(Table AutomobileVehicledata)
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
            snapShot.TakeSnap("AutomobileVehicleData");
            automobilePage.ClickNextButton();
        }

        [Then(@"I fill the enter product data details for automobile")]
        public void ThenIFillTheEnterProductDataDetailsForAutomobile(Table automobileProductData)
        {
            var dataTableValues = automobileProductData.CreateInstance<DataTables>();
            automobilePage.SetStartDate(DateTime.Parse(dataTableValues.StartDate).AddDays(80).ToString("MM/dd/yyyy"));
            automobilePage.SetInsuranceSum(dataTableValues.InsurancSum);
            automobilePage.SetMeritRating(dataTableValues.MeritRating);
            automobilePage.SetDamageInsurance(dataTableValues.DamageInsurance);
            automobilePage.SelectEuroProtection();
            automobilePage.SetCourtesuCar(dataTableValues.CourtesyCar);
            snapShot.TakeSnap("ProductData");
            automobilePage.ClickProductDataNextButton();
        }
    }
}
