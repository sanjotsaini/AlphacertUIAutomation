using AlphacertTest.PageObject;
using AlphacertTest.ScreenShots;
using AlphacertTest.Utilities;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AlphacertTest.FeaturesSteps
{
    [Binding]
    public class TruckSteps
    {
        private readonly HomePage homePage;
        private readonly AutomobilePage automobilePage;
        private readonly TruckPage truckPage;
        private readonly SnapShot snapShot;
        private readonly ScenarioContext _scenarioContext;

        public TruckSteps(ScenarioContext scenarioContext)
        {
            this.homePage = new HomePage();
            this.automobilePage = new AutomobilePage();
            this.snapShot = new SnapShot();
            this.truckPage = new TruckPage();
            this._scenarioContext = scenarioContext;
        }


        [When(@"I navigate to truck isurance")]
        public void WhenINavigateToTruckIsurance()
        {
            homePage.NavigateToTruck();
        }
        
        [When(@"I fill the vehicle data details truck")]
        public void WhenIFillTheVehicleDataDetailsTruck(Table vehicledata)
        {
            var dataTableValues = vehicledata.CreateInstance<DataTables>();
            automobilePage.SetMake(dataTableValues.Make);
            automobilePage.SetDateOfManufacture(dataTableValues.DateOfManufacture);
            automobilePage.SetEnginePerformance(dataTableValues.EnginePerformance);
            automobilePage.SetNumberOfSeats(dataTableValues.NumberOfSeats);
            automobilePage.SetFuelType(dataTableValues.FuelType);
            truckPage.SetPayload(dataTableValues.Payload);
            truckPage.SetTotalWeight(dataTableValues.TotalWeight);
            automobilePage.SetListPrice(dataTableValues.ListPrice);
            automobilePage.SetLicensePlateNumber(dataTableValues.LicencePlateNumber);
            automobilePage.SetAnnualMileage(dataTableValues.AnualMilage);
            snapShot.TakeSnap(_scenarioContext.StepContext.StepInfo.Text.Replace(" ", ""));
            automobilePage.ClickNextButton();
        }
        
        [When(@"I fill the enter product data details for truck")]
        public void WhenIFillTheEnterProductDataDetailsForTruck(Table truckProductData)
        {
            var dataTableValues = truckProductData.CreateInstance<DataTables>();
            automobilePage.SetStartDate(DateTime.Parse(dataTableValues.StartDate).AddDays(80).ToString("MM/dd/yyyy"));
            automobilePage.SetInsuranceSum(dataTableValues.InsurancSum);
            automobilePage.SetDamageInsurance(dataTableValues.DamageInsurance);
            automobilePage.SelectEuroProtection();
            snapShot.TakeSnap(_scenarioContext.StepContext.StepInfo.Text.Replace(" ", ""));
            automobilePage.ClickProductDataNextButton();
        }
    }
}
