using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAL_UI_Framework.Pages
{
    public class HomePage
    {
        private IWebDriver Driver;

        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement ContactUsFooter => Driver.FindElement(By.CssSelector("#Default > aside > span > a:nth-child(1)"));

        IWebElement InsuranceProducts => Driver.FindElement(By.CssSelector("#nav > ul > li:nth-child(2) > a"));

        IWebElement LifeInsurance => Driver.FindElement(By.CssSelector("#nav > ul > li.has-children.is-active > div > div > ul > li:nth-child(3) > a"));

        IWebElement Claims => Driver.FindElement(By.CssSelector("#nav > ul > li:nth-child(4) > a"));

        IWebElement ClaimsUnderClaims => Driver.FindElement(By.CssSelector("#nav > ul > li.has-children.is-active > div > div > ul > li.hidden-until\\@m > a"));

        public void  ClickContactUsFooter() => ContactUsFooter.Click();

        public void ClickInsuranceProducts() => InsuranceProducts.Click();

        public void ClickLifeInsurance() => LifeInsurance.Click();  

        public void ClickClaims() => Claims.Click();

        public void ClickClaimsUnderClaims() => ClaimsUnderClaims.Click();
    }
}
