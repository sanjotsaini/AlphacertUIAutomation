TRICENTIS UI Test Automation

Project Description:
TRICENTIS is as vehicle insurance web application where you get the quote of your vehicle. So, I have Created the test automation project for this application to reduce the manual testing workload. 
TRUCENTIS UI test automation project framework is created using Selenium 3, BBD- Spec flow on top of C#.net core platform to code test scenarios using Tricentis website. Design pattern used to develop the framework is Page Object Model. Reporting feature is Extent Report in html format

Functional Scenarios picked for testing:

1.	End-To-End test to get the quote of automobile insurance by filling all the details and send the quote. Test verifies when quote is sent “Sending e-mail success! message pop out is received.
2.	 End-To-End test to get the quote of truck insurance by filling all the details and send the quote. Test verifies when quote is sent “Sending e-mail success!” message pop out is received.  

Design Pattern Used: Page Object Model Pattern: -

I have used page object model pattern to code this framework and utilized BDD: Spec flow to write     the scenarios. The below is more details framework structure:

This is a web UI automation framework coded using Specflow BDD and C#. netcore. It is based on page object model pattern. Where each page represents a page on the Tricentis website 
Folder Structure and Pattern details:
1.	BaseClasses: - Contains classes and methods to initiate the web driver, select the web driver and setting of web driver (Chrome Options), Create Extent reports and take screen shots.
2.	ComponentHelper: - Contains classes and method to perform the action on components on website of Tricentis  
3.	Configuration: - Contains Enum, Classes and Methods to read the information from App.config and Enums contains the types of browser
4.	CustomeException: - Contains the class and methods to create custom exception for example Driver not found 
5.	Feature Files: - This folder contains the feature file that has the test scenarios to be tested in Gherkin language format.
6.	Step Definitions: - This folder contains the step definition file that has all the test steps from the Gherkin matched to underlying page object functionality.
7.	Page Objects: - It contains class Automobile.cs that contains locators for different elements on the page and methods used to test different functionality on the page. Likewise, it contains the classes HomePage.cs and TruckPage.cs
8.	Reports: - Contains the Reports of test run. Reports are Extent report in html format.
9.	ScreenShots: - Contains the class and methods to take screenshot and path where to store the screen shots.
10.	Settings: - Contains Classes which sets the App.config files keys which helps to change the Key value in Appconfig file anytime and Object Repository contains the object and property used by other class in Framework
11.	Utilities: - Contains class Validator to Assert the test result and Data tables class to store the data table variables 
        
Code Repository: I have used GitHub Code repository to store my Code below is the link to the repository
LINK: - sanjotsaini/AlphacertUIAutomation (github.com)

Software Requirement: -  

1.	Windows 10,7,8…
2.	Microsoft Visual Studio 2019 or 2017…
3.	Chrome Browser 88.0 installed.

Nugget Package Requirement: - 
  
1.	Selenium Support
2.	Selenium Webdriver
3.	Specflow
4.	SpecFlow.Tools.MsBuild.Generation
5.	SpecFlow.NetCore
6.	Extent Report

Test Execution: - 

1.	Download the project from GitHub (sanjotsaisssni/AlphacertUIAutomation (github.com))
2.	Download Install Microsoft Visual Studio 2019
3.	Open the AlphacertTest.sln file in Visual studio 2019
4.	Build the Project
5.	If you don't see the Test Explorer, Go to Test --> Test Explorer. Run the tests from there.
6.	Right click on the test and Run the project

NOTE: - Make sure Webdriver.exe in bin/Debug directory is of same version of you chrome browser

How to Check the Report?: - Right Click on Report folder --> select open in file explorer --> open Todays date folder --> open the Index.html




