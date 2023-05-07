using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAL_UI_Framework.Drivers;

namespace TAL_UI_Framework.Pages
{
    public class LifeInsurancePage
    {
        private IWebDriver Driver;
        public LifeInsurancePage(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement GetAQuote => Driver.FindElement(By.CssSelector("#home-banner > div > div > div > div.btn-holder > a"));


        //  Get a quote Step 1 of 2
        IWebElement DOB => Driver.FindElement(By.CssSelector("div:nth-child(1) > div.tal-gel-163hd9e > div > input"));
        IWebElement YourGenderMale => Driver.FindElement(By.CssSelector("div.tal-gel-om8z9i > form > div:nth-child(2) .tal-gel-867rwy label"));
        IWebElement DoYouSmokeYes => Driver.FindElement(By.CssSelector("div.tal-gel-om8z9i > form > div:nth-child(3) .tal-gel-867rwy label"));
        IWebElement Occupation => Driver.FindElement(By.CssSelector("form > div:nth-child(4) > div.tal-gel-163hd9e > div > div  > input"));

        IWebElement OccupationDropdownArrow => Driver.FindElement(By.CssSelector("div > div > span.tal-gel-9caotm > svg"));
        IWebElement AnnualIncome => Driver.FindElement(By.CssSelector("form > div:nth-child(6) > div.tal-gel-163hd9e > div >input"));
        IWebElement ContinueBtn => Driver.FindElement(By.CssSelector("div:nth-child(7) > div > button > span:nth-child(1)"));


        //  Get a quote Step 2 of 2
        IWebElement FirstName => Driver.FindElement(By.CssSelector("form > div:nth-child(2) > div.tal-gel-163hd9e > div > input"));
        IWebElement LastName => Driver.FindElement(By.CssSelector("div:nth-child(3) > div.tal-gel-163hd9e > div > input"));
        IWebElement Phone => Driver.FindElement(By.CssSelector("div:nth-child(4) > div.tal-gel-163hd9e > div > input"));
        IWebElement Email => Driver.FindElement(By.CssSelector("div:nth-child(5) > div.tal-gel-163hd9e > div > input"));
        IWebElement Postcode => Driver.FindElement(By.CssSelector("div:nth-child(6) > div.tal-gel-163hd9e > div > input"));


        IWebElement CalculateMyQuoteBtn => Driver.FindElement(By.CssSelector("form > div:nth-child(8) > div > button"));
        IWebElement LifeinsurancePlanBenefits => Driver.FindElement(By.CssSelector("div > div:nth-child(3) >div button:nth-child(1)"));

        IWebElement CoverAmount => Driver.FindElement(By.CssSelector("div.tal-gel-163hd9e > div > div > div > div >input"));
        IWebElement CoverAmountArrow => Driver.FindElement(By.CssSelector("span.tal-gel-9caotm > svg"));

        IWebElement ConfirmBtn => Driver.FindElement(By.CssSelector("div:nth-child(6) > div > div > div > button"));
        IWebElement CoverContinueBtn => Driver.FindElement(By.CssSelector("div.tal-gel-1qjf2i6 > div > div > div:nth-child(2) > button"));
        IWebElement SuccessMessage => Driver.FindElement(By.CssSelector("div:nth-child(2) > div > div > h4"));


        public void ClickGetAQuote() => GetAQuote.Click();
        public void SelectYourGenderMale() => YourGenderMale.Click();
        public void SelectDoYouSmokeYes() => DoYouSmokeYes.Click();
        public void EnterAnnualIncome(string value) => AnnualIncome.SendKeys(value);
        public void EnterFirstName(string value) => FirstName.SendKeys(value);
        public void EnterLastName(string value) => LastName.SendKeys(value);
        public void EnterPhone(string value) => Phone.SendKeys(value);
        public void EnterEmail(string value) => Email.SendKeys(value);
        public void EnterPostcode(string value) => Postcode.SendKeys(value);
 
        public void ClickConfirmBtn() => ConfirmBtn.Click();
        public void SelectCoverContinueBtn() => CoverContinueBtn.Click();


        public void EnterDOB(string value)
        {
            DOB.Click();
            DOB.SendKeys(value);
            DOB.SendKeys(Keys.Tab);
        }
        public void EnterOccupation(string value)
        {
            Occupation.SendKeys(value);
            OccupationDropdownArrow.Click();
        }

        public void EnterCoverAmount(string value)
        {
            CoverAmount.Click();
            CoverAmount.SendKeys(value);
            CoverAmount.SendKeys(Keys.Tab);
            CoverAmountArrow.Click();
        }
        public string GetSuccessMessage()
        {
            return SuccessMessage.Text;
        }

        public void ClickContinueBtn()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20))
            {
                PollingInterval = TimeSpan.FromSeconds(2)
            };

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("div:nth-child(7) > div > button > span:nth-child(1)")));
            ContinueBtn.Click();
        }

        public void ClickCalculateMyQuoteBtn()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20))
            {
                PollingInterval = TimeSpan.FromSeconds(2)
            };

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("form > div:nth-child(8) > div > button")));
            CalculateMyQuoteBtn.Click();
        }

        public void SelectLifeinsurancePlanBenefits()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(40))
            {
                PollingInterval = TimeSpan.FromSeconds(2)
            };

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("#LI > div > div > div.tal-gel-1eqlbok > button")));
            LifeinsurancePlanBenefits.Click();
        }
    }
}
