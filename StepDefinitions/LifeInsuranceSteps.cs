using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAL_UI_Framework.Drivers;
using TAL_UI_Framework.Pages;
using TechTalk.SpecFlow.Assist;

namespace TAL_UI_Framework.StepDefinitions
{
    [Binding]
    public class LifeInsuranceSteps
    {
        private DriverHelper _driverHelper;
        LifeInsurancePage lifeInsurancePage;
        public LifeInsuranceSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            lifeInsurancePage = new LifeInsurancePage(_driverHelper.Driver);
        }

        [When(@"The user selects the option Get a quote on lifeinsurance page")]
        public void WhenTheUserSelectsTheOptionGetAQuoteOnLifeinsurancePage()
        {
            lifeInsurancePage.ClickGetAQuote();
        }

        [When(@"The user fills the life insurance page with below options")]
        public void WhenTheUserFillsTheLifeInsurancePageWithBelowOptions(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            lifeInsurancePage.EnterDOB(data.DOB);
            lifeInsurancePage.SelectYourGenderMale();
            lifeInsurancePage.SelectDoYouSmokeYes();
            lifeInsurancePage.EnterOccupation(data.Occupation);
            lifeInsurancePage.EnterAnnualIncome(data.AnnualIncome);

            lifeInsurancePage.ClickContinueBtn();
        }

        [When(@"the user enters the life insurance page with below options")]
        public void WhenTheUserEntersTheLifeInsurancePageWithBelowOptions(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            lifeInsurancePage.EnterFirstName(data.FirstName);
            lifeInsurancePage.EnterLastName(data.LastName);
            lifeInsurancePage.EnterPhone(data.Phone);
            lifeInsurancePage.EnterEmail(data.Email);
            lifeInsurancePage.EnterPostcode(data.PostCode);

            lifeInsurancePage.ClickCalculateMyQuoteBtn();
        }

        [When(@"The user selects Life Insurance Plan as Add a benefit to get started")]
        public void WhenTheUserSelectsLifeInsurancePlanAsAddABenefitToGetStarted()
        {
            lifeInsurancePage.SelectLifeinsurancePlanBenefits();
        }

        [When(@"The user enters the Cover Amount of (.*)")]
        public void WhenTheUserEntersTheCoverAmountOf(string CoverAmount)
        {
            lifeInsurancePage.EnterCoverAmount(CoverAmount);
        }

        [When(@"The user clicks on the Confirm button")]
        public void WhenTheUserClicksOnTheConfirmButton()
        {
            lifeInsurancePage.ClickConfirmBtn();
        }

        [When(@"The user clicks on the Continue button")]
        public void WhenTheUserClicksOnTheContinueButton()
        {
            lifeInsurancePage.SelectCoverContinueBtn();
        }

        [Then(@"Verify we get the ""([^""]*)"" message")]
        public void ThenVerifyWeGetTheMessage(string expectedText)
        {
            string actualText = lifeInsurancePage.GetSuccessMessage();
            Assert.AreEqual(actualText, expectedText, "Success Message not matching");
        }
    }
}
