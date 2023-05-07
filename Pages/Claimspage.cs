using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAL_UI_Framework.Pages
{
    public class Claimspage
    {
        private IWebDriver Driver;
        public Claimspage(IWebDriver driver)
        {
            Driver = driver;
        }
        IWebElement MakeaClaim => Driver.FindElement(By.CssSelector("#make-a-claim > aside > span > a"));

        IWebElement RecoveryTraumaInsurance => Driver.FindElement(By.CssSelector("#tabz-1-tabkey-2 > div"));

        public void ClickMakeaClaim() => MakeaClaim.Click();    
        public void ClickRecoveryTraumaInsurance() => RecoveryTraumaInsurance.Click();  
    }
}
