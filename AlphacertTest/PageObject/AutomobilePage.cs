using AlphacertTest.ComponentHelper;
using AlphacertTest.ScreenShots;
using AlphacertTest.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphacertTest.PageObject
{
   public class AutomobilePage
    {

        private readonly SnapShot snapShot;

        public AutomobilePage()
        {
            this.snapShot = new SnapShot();
        }



        #region WebElements

        
        private IWebElement MakeDropdown => ObjectRepository.Driver.FindElement(By.Id("make"));
        
        private IWebElement NumberOfSeatsDropdown => ObjectRepository.Driver.FindElement(By.Id("numberofseats"));
        
        private IWebElement Fueltype => ObjectRepository.Driver.FindElement(By.Id("fuel"));
        
        private IWebElement EnginePerformanceText => ObjectRepository.Driver.FindElement(By.Id("engineperformance"));
        
        private IWebElement ListPriceText => ObjectRepository.Driver.FindElement(By.Id("listprice"));
        
        private IWebElement LicensePlateNumberText => ObjectRepository.Driver.FindElement(By.Id("licenseplatenumber"));
        
        private IWebElement AnnualMileageText => ObjectRepository.Driver.FindElement(By.Id("annualmileage"));
       
        private IWebElement DateOfManufactureDatePickler => ObjectRepository.Driver.FindElement(By.Id("dateofmanufacture"));
        
        private IWebElement NextButton => ObjectRepository.Driver.FindElement(By.Id("nextenterinsurantdata"));

        private IWebElement FirstNameText => ObjectRepository.Driver.FindElement(By.Id("firstname"));

        private IWebElement LastNameText => ObjectRepository.Driver.FindElement(By.Id("lastname"));

        private IWebElement DOBText => ObjectRepository.Driver.FindElement(By.Id("birthdate"));

        private IWebElement GenderMaleRadioBttn => ObjectRepository.Driver.FindElement(By.XPath("//div[@class = 'field']/p/label[text() ='Male']"));

        private IWebElement GenderFemaleBttn => ObjectRepository.Driver.FindElement(By.XPath("//div[@class = 'field']/p/label[text() ='Female']"));

        private IWebElement StreetAddressTxt => ObjectRepository.Driver.FindElement(By.Id("streetaddress"));

        private IWebElement CountryDropDwn => ObjectRepository.Driver.FindElement(By.Id("country"));

        private IWebElement ZipCodeTxt => ObjectRepository.Driver.FindElement(By.Id("zipcode"));

        private IWebElement CityTxt => ObjectRepository.Driver.FindElement(By.Id("city"));

        private IWebElement OccupationDropDwn => ObjectRepository.Driver.FindElement(By.Id("occupation"));

        private IWebElement HobbiesSpeedingRadioBttn => ObjectRepository.Driver.FindElement(By.XPath("//p[@class='group']/label[text() = ' Speeding']"));

        private IWebElement HobbiesSkyDivingRadioBttn => ObjectRepository.Driver.FindElement(By.XPath("//p[@class='group']/label[text() = ' Skydiving']"));

        private IWebElement WebsiteTxt => ObjectRepository.Driver.FindElement(By.Id("website"));

        private IWebElement InsuranceDatNextBttn => ObjectRepository.Driver.FindElement(By.Id("nextenterproductdata"));

        //ProductData Elements

        private IWebElement StartDateBttn => ObjectRepository.Driver.FindElement(By.Id("startdate"));
        private IWebElement InsuranceSunDropDwn => ObjectRepository.Driver.FindElement(By.Id("insurancesum"));
        private IWebElement MeritRatingDropDwn => ObjectRepository.Driver.FindElement(By.Id("meritrating"));
        private IWebElement DamageInsuranceDropDwn => ObjectRepository.Driver.FindElement(By.Id("damageinsurance"));
        private IWebElement OptionalProductsEuro => ObjectRepository.Driver.FindElement(By.XPath("//p[@class='group']/label[text() = 'Euro Protection']"));
        private IWebElement OptionalProductsLegal => ObjectRepository.Driver.FindElement(By.XPath("//p[@class='group']/label[text() = 'Legal Defense Insurance']"));
        private IWebElement CourtesyCarDropDwn => ObjectRepository.Driver.FindElement(By.Id("courtesycar"));
        private IWebElement ProductDataNextBttn => ObjectRepository.Driver.FindElement(By.Id("nextselectpriceoption"));

        private IWebElement SelectSilverRadioBttn => ObjectRepository.Driver.FindElement(By.XPath("//input[@id = 'selectsilver']/parent::*"));
        private IWebElement SelecetPriceOptionNextBttn => ObjectRepository.Driver.FindElement(By.Id("nextsendquote"));

        private IWebElement EmailTxt => ObjectRepository.Driver.FindElement(By.Id("email"));
        private IWebElement UsernameTxt => ObjectRepository.Driver.FindElement(By.Id("username"));
        private IWebElement PasswordText => ObjectRepository.Driver.FindElement(By.Id("password"));
        private IWebElement ConfirmPasswordTxt => ObjectRepository.Driver.FindElement(By.Id("confirmpassword"));
        private IWebElement CommentTxt => ObjectRepository.Driver.FindElement(By.Id("Comments"));
        private IWebElement SendQuoteBttn => ObjectRepository.Driver.FindElement(By.Id("sendemail"));

        private IWebElement EmailSentText => ObjectRepository.Driver.FindElement(By.XPath("//div[@class = 'sweet-alert showSweetAlert visible']/h2"));








        #endregion





        #region Actions
        public void SetMake(string name )

        {
            WaitHelper.ThinkTime(1);
            DropDownHelper.SelectElement(MakeDropdown, name);

        }

        public void SetNumberOfSeats(string name)

        {
            WaitHelper.ThinkTime(1);
            DropDownHelper.SelectElement(NumberOfSeatsDropdown, name);

        }
        public void SetFuelType(string name)

        {
            WaitHelper.ThinkTime(1);
            DropDownHelper.SelectElement(Fueltype, name);

        }

        public void SetEnginePerformance(string name)

        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(EnginePerformanceText, name);

        }
        public void SetListPrice(string name)

        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(ListPriceText, name);

        }
        public void SetLicensePlateNumber(string name)

        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(LicensePlateNumberText, name);

        }
        public void SetAnnualMileage(string name)

        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(AnnualMileageText, name);

        }

        public void SetDateOfManufacture(string name)

        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(DateOfManufactureDatePickler, name);

        }

       
        public void SetFirstName(string value)

        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(FirstNameText,value);

        }
        public void SetLastName(string value)

        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(LastNameText, value);

        }

        public void SetDOB(string value)

        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(DOBText, value);

        }

        public void SetGenderMale()

        {
            WaitHelper.ThinkTime(1);
            ButtonHelper.ClickButton(GenderMaleRadioBttn);

        }

        public void SetGenderFemaleMale()

        {
            WaitHelper.ThinkTime(1);
            ButtonHelper.ClickButton(GenderFemaleBttn);

        }

        public void SetStreetAdress(string value)

        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(StreetAddressTxt, value);

        }

        public void SetCountry(string value)

        {

            WaitHelper.ThinkTime(1);
            DropDownHelper.SelectElement(CountryDropDwn, value);
        }
        public void SetZipCode(string value)

        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(ZipCodeTxt, value);

        }
        public void SetCity(string value)

        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(CityTxt, value);
        }

        public void SetOccupation(string value)

        {
            WaitHelper.ThinkTime(1);
            DropDownHelper.SelectElement(OccupationDropDwn, value);
        }

        public void SetHobbiesSpeeding()

        {
            WaitHelper.ThinkTime(1);
            ButtonHelper.ClickButton(HobbiesSpeedingRadioBttn);
        }

        public void SetHobbiesSkyDiving()

        {
            WaitHelper.ThinkTime(1);
            ButtonHelper.ClickButton(HobbiesSkyDivingRadioBttn);

        }
        public void SetWebsite(string value)

        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(WebsiteTxt, value);

        }


        public void SetStartDate(string value)

        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(StartDateBttn, value);

        }


        public void SetInsuranceSum(string value)

        {

            WaitHelper.ThinkTime(1);
            DropDownHelper.SelectElement(InsuranceSunDropDwn, value);
        }

        public void SetMeritRating(string value)

        {

            WaitHelper.ThinkTime(1);
            DropDownHelper.SelectElement(MeritRatingDropDwn, value);
        }

        public void SetDamageInsurance(string value)

        {

            WaitHelper.ThinkTime(1);
            DropDownHelper.SelectElement(DamageInsuranceDropDwn, value);
        }

        public void SetCourtesuCar(string value)

        {

            WaitHelper.ThinkTime(1);
            DropDownHelper.SelectElement(CourtesyCarDropDwn, value);
        }

        public void SelectEuroProtection()

        {
            WaitHelper.ThinkTime(10);
            ButtonHelper.ClickButton(OptionalProductsEuro);
        }
        public void SelectLegalDefeceInsurance()

        {
            WaitHelper.ThinkTime(1);
            ButtonHelper.ClickButton(OptionalProductsLegal);
        }


        public void SelectSilverPrice()

        {
            WaitHelper.ThinkTime(50);
            ButtonHelper.ClickButton(SelectSilverRadioBttn);
        }

        public void SetEmail(string value)

        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(EmailTxt, value);

        }
        public void SetUsername(string value)

        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(UsernameTxt, value);

        }
        public void SetPassword(string value)

        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(PasswordText, value);

        }
        public void SetConfirmPassword(string value)

        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(ConfirmPasswordTxt, value);

        }
        public void SetComments(string value)

        {
            WaitHelper.ThinkTime(1);
            TextBoxHelper.setTextBoxValue(CommentTxt, value);

        }

        public string GetEmailSentText()
        {
            WaitHelper.ThinkTime(50);
                        
            return TextBoxHelper.GetTextBoxValue(EmailSentText);

        }



        #endregion

        #region Navigation

        public void ClickNextButton()

        {
            WaitHelper.ThinkTime(1);
            ButtonHelper.ClickButton(NextButton);

        }

        public void ClickInsuranceDataNextButton()

        {
            WaitHelper.ThinkTime(1);
            ButtonHelper.ClickButton(InsuranceDatNextBttn);

        }

        public void ClickProductDataNextButton()

        {
            WaitHelper.ThinkTime(1);
            ButtonHelper.ClickButton(ProductDataNextBttn);

        }

        public void ClickSelectPriceoptionNextButton()

        {
            WaitHelper.ThinkTime(1);
            ButtonHelper.ClickButton(SelecetPriceOptionNextBttn);

        }
        public void ClickSendQuoteButton()

        {
            WaitHelper.ThinkTime(1);
            ButtonHelper.ClickButton(SendQuoteBttn);

        }


        #endregion



        public  class IsuranceData
        {
            private  IWebElement FirstNameText => ObjectRepository.Driver.FindElement(By.Id("firstname"));

            public  void SetFirstName(string value)

            {
                WaitHelper.ThinkTime(1);
                TextBoxHelper.setTextBoxValue(FirstNameText, value);

            }
        }

    }
}
