﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.7.0.0
//      SpecFlow Generator Version:3.7.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AlphacertTest.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.7.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AutombileInsurance")]
    public partial class AutombileInsuranceFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Login.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "AutombileInsurance", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get the Quote of Automobile Insurance")]
        [NUnit.Framework.CategoryAttribute("Automobile")]
        [NUnit.Framework.CategoryAttribute("Positive")]
        public virtual void GetTheQuoteOfAutomobileInsurance()
        {
            string[] tagsOfScenario = new string[] {
                    "Automobile",
                    "Positive"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the Quote of Automobile Insurance", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
 testRunner.Given("I visit to Tricentie website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.And("I navigate to automobile isurance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Values"});
                table1.AddRow(new string[] {
                            "Make",
                            "BMW"});
                table1.AddRow(new string[] {
                            "EnginePerformance",
                            "236"});
                table1.AddRow(new string[] {
                            "DateOfManufacture",
                            "02/04/2007"});
                table1.AddRow(new string[] {
                            "NumberOfSeats",
                            "5"});
                table1.AddRow(new string[] {
                            "FuelType",
                            "Petrol"});
                table1.AddRow(new string[] {
                            "ListPrice",
                            "50000"});
                table1.AddRow(new string[] {
                            "LicencePlateNumber",
                            "LSU335"});
                table1.AddRow(new string[] {
                            "AnualMilage",
                            "300"});
#line 9
 testRunner.Then("I fill the vehicle data details", ((string)(null)), table1, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Values"});
                table2.AddRow(new string[] {
                            "FirstName",
                            "Sanjot"});
                table2.AddRow(new string[] {
                            "LastName",
                            "Saini"});
                table2.AddRow(new string[] {
                            "DOB",
                            "12/26/1993"});
                table2.AddRow(new string[] {
                            "Gender",
                            "Male"});
                table2.AddRow(new string[] {
                            "StreetAddress",
                            "39,Magnolia drive"});
                table2.AddRow(new string[] {
                            "Country",
                            "New Zealand"});
                table2.AddRow(new string[] {
                            "ZipCode",
                            "4310"});
                table2.AddRow(new string[] {
                            "City",
                            "New Plymouth"});
                table2.AddRow(new string[] {
                            "Occupation",
                            "Farmer"});
                table2.AddRow(new string[] {
                            "Hobbies",
                            "SkyDiving"});
                table2.AddRow(new string[] {
                            "Website",
                            "https://facebook.com"});
#line 19
 testRunner.Then("I fill the insurance data details", ((string)(null)), table2, "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Values"});
                table3.AddRow(new string[] {
                            "StartDate",
                            "05/03/2021"});
                table3.AddRow(new string[] {
                            "InsurancSum",
                            "7.000.000,00"});
                table3.AddRow(new string[] {
                            "MeritRating",
                            "Bonus 7"});
                table3.AddRow(new string[] {
                            "DamageInsurance",
                            "Full Coverage"});
                table3.AddRow(new string[] {
                            "OptionalProducts",
                            ""});
                table3.AddRow(new string[] {
                            "CourtesyCar",
                            "Yes"});
#line 32
 testRunner.Then("I fill the enter product data details", ((string)(null)), table3, "Then ");
#line hidden
#line 40
 testRunner.Then("I select the price option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Values"});
                table4.AddRow(new string[] {
                            "Email",
                            "sainisanjot26@gmail.com"});
                table4.AddRow(new string[] {
                            "Username",
                            "sainisa"});
                table4.AddRow(new string[] {
                            "Password",
                            "Password@123"});
                table4.AddRow(new string[] {
                            "ConfirmPassword",
                            "Password@123"});
                table4.AddRow(new string[] {
                            "Comment",
                            "Test"});
#line 41
 testRunner.Then("I fill the send qoute details", ((string)(null)), table4, "Then ");
#line hidden
#line 48
 testRunner.And("I click the send button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.Then("I verify the quote is sent succesfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion