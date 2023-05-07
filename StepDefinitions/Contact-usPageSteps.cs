using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TAL_UI_Framework.Drivers;
using TAL_UI_Framework.Pages;
using TechTalk.SpecFlow.Assist;

namespace TAL_UI_Framework.StepDefinitions
{
    [Binding]
    public class Contact_usPageSteps
    {
        private DriverHelper _driverHelper;
        Contact_usPage contact_UsPage;

        public Contact_usPageSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            contact_UsPage = new Contact_usPage(_driverHelper.Driver); 
        }

        [When(@"The user fill the Contact us page with below values")]
        public void WhenTheUserFillTheContactUsPageWithBelowValues(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            contact_UsPage.EnterName(data.Name);
            contact_UsPage.EnterEmail(data.Email);
            contact_UsPage.EnterPhone(data.Phone.ToString());
            contact_UsPage.EnterYourquery(data.Query);
        }

        [When(@"The user selects the value ""([^""]*)"" from the IwanttoDropdown")]
        public void WhenTheUserSelectsTheValueFromTheIwanttoDropdown(string value)
        {
            contact_UsPage.SelectValueIwanttoDropdown(value);
        }


        [When(@"The user checks the i'm not a robot captch")]
        public void WhenTheUserChecksTheImNotARobotCaptch()
        {
            contact_UsPage.NotaRobotCheckboxClick();
            Thread.Sleep(2000);  // wait for check box animation to finish.
        }


        [When(@"The user click on the send message button")]
        public void WhenTheUserClickOnTheSendMessageButton()
        {
            contact_UsPage.SendMessageBtnClick();
        }

        [Then(@"The user should see the message ""([^""]*)"" message")]
        public void ThenTheUserShouldSeeTheMessageMessage(string expectedMessage)
        {
            string actualMessage = contact_UsPage.GetSuccessMessage();
            Assert.AreEqual(actualMessage, expectedMessage);
        }
    }
}
