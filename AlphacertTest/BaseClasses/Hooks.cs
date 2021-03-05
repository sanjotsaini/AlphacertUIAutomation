using AlphacertTest.ScreenShots;
using AlphacertTest.Settings;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AlphacertTest.BaseClasses
{
    [Binding]
    public sealed class Hooks
    {
        public static ScenarioContext _scenarioContext;
        private static FeatureContext _featureContext;
        private static ExtentReports _extentReports;
        private static ExtentHtmlReporter _extentHtmlReporter;
        private static ExtentTest _feature;
        private static ExtentTest _scenario;
        private readonly SnapShot snapshot;

        public Hooks()
        {
            this.snapshot = new SnapShot();
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            _extentHtmlReporter = new ExtentHtmlReporter(SnapShot.GetCertificate());
            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(_extentHtmlReporter);

        }
        [BeforeFeature]
        public static void BeforeFeatureStart(FeatureContext featureContext)
        {
            if(featureContext != null)
            {
                _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title,
                    featureContext.FeatureInfo.Description);

            }

        }

        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext scenarioContext)
        {
             BaseClass.InitWebdriver();
            if (scenarioContext != null)
            {
                _scenarioContext = scenarioContext;
                _scenario =_feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title,//return Type of this is Extent Test
                    scenarioContext.ScenarioInfo.Description);

            }

        }

        [AfterStep]
        public void AfterStep()
        {
            ScenarioBlock scenarioBlock = _scenarioContext.CurrentScenarioBlock;

            switch (scenarioBlock)
            {
              
                case ScenarioBlock.Given:
                    if (_scenarioContext.TestError != null)
                    {
                       
                        snapshot.TakeSnap(_scenarioContext.StepContext.StepInfo.Text.Replace(" ", ""));
                        _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message+"\n" +
                            _scenarioContext.TestError.StackTrace);

                    }
                    else
                    {
                        _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text).Pass("Step is passed");
                    }
                    
                    break;
                case ScenarioBlock.When:
                    if (_scenarioContext.TestError != null)
                    {

                        string path = SnapShot.GetCertificate(_scenarioContext.StepContext.StepInfo.Text.Replace(" ", ""));
                        snapshot.TakeSnap(_scenarioContext.StepContext.StepInfo.Text.Replace(" ", ""));
                        _scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message+"\n" +
                            _scenarioContext.TestError.StackTrace).AddScreenCaptureFromPath(SnapShot.GetCertificate(_scenarioContext.StepContext.StepInfo.Text.Replace(" ", "")+".jpeg"));

                    }
                    else
                    {
                        _scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Pass("Test is Passed");
                    }
                    break;
                case ScenarioBlock.Then:
                    if (_scenarioContext.TestError != null)
                    {
                        
                        snapshot.TakeSnap(_scenarioContext.StepContext.StepInfo.Text.Replace(" ", ""));
                        _scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message+"\n" +
                            _scenarioContext.TestError.StackTrace);

                    }
                    else
                    {
                        _scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text).Pass("Test is passed");
                    }
                    break;
                default:
                    string name = _scenarioContext.StepContext.StepInfo.Text.Replace(" ", "");
                    snapshot.TakeSnap(name);
                    if (_scenarioContext.TestError != null)
                    {
                        _scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message + "\n" +
                            _scenarioContext.TestError.StackTrace);

                    }
                    else
                    {
                        _scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text).Pass("Test is passed");
                    }
                    break;


            }


        }

        [AfterScenario]
        public void AfterScenario()
        {

        }


        [AfterTestRun]
        public static void AfterTestRun()
        {
            _extentReports.Flush();
            if(ObjectRepository.Driver != null)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }

        public static  string GetCertificate()
        {
            var jsonFilePath = Path.Combine(GetCertificatePath(DateTime.UtcNow.ToString("yyyy-MM-dd-hh-mm-ss")) + @"/");
            return jsonFilePath;
        }

        private static string GetCertificatePath(string apiType)
        {
            var assemblyPath = AppContext.BaseDirectory;
            var actualPath = assemblyPath.Substring(0, assemblyPath.LastIndexOf("bin"));
            var projectPath = new Uri(actualPath).LocalPath;
            return projectPath + @"Reports/" + apiType;
        }
    }
}
