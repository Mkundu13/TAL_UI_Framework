using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAL_UI_Framework.Helpers;

namespace TAL_UI_Framework.Pages
{
    public class Contact_usPage
    {
        private IWebDriver Driver;
        public Contact_usPage(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement Name => Driver.FindElement(By.Id("wffm7bcebacf323c4981a33eab005b609b0f_Sections_0__Fields_0__Value"));
        IWebElement Email => Driver.FindElement(By.Id("wffm7bcebacf323c4981a33eab005b609b0f_Sections_0__Fields_1__Value"));
        IWebElement Phone => Driver.FindElement(By.Id("wffm7bcebacf323c4981a33eab005b609b0f_Sections_0__Fields_2__Value"));
        IWebElement IwanttoDropdown => Driver.FindElement(By.Id("wffm7bcebacf323c4981a33eab005b609b0f_Sections_0__Fields_5__Value"));
        IWebElement Yourquery => Driver.FindElement(By.Id("wffm7bcebacf323c4981a33eab005b609b0f_Sections_0__Fields_6__Value"));
        IWebElement NotaRobotCheckbox => Driver.FindElement(By.CssSelector("#recaptcha-anchor > div.recaptcha-checkbox-border"));
        IWebElement SendMessageBtn => Driver.FindElement(By.CssSelector("#wffm7bcebacf323c4981a33eab005b609b0f > div.form-submit-border > input"));
        IWebElement SuccessMessage => Driver.FindElement(By.CssSelector("#main > article > header > div > h1"));


        public void EnterName(string name) => Name.SendKeys(name);
        public void EnterEmail(string email) => Email.SendKeys(email);
        public void EnterPhone(string phonenumber) => Phone.SendKeys(phonenumber);
        public void EnterYourquery(string yourquery) => Yourquery.SendKeys(yourquery);
        public void SendMessageBtnClick() => SendMessageBtn.Click();

        public void NotaRobotCheckboxClick()
        {
            Driver.SwitchTo().Frame(Driver.FindElement(By.TagName("iframe")));
            NotaRobotCheckbox.Click();
            Driver.SwitchTo().DefaultContent();
        }
        public string GetSuccessMessage()
        {
            return SuccessMessage.Text;
        }
        public void SelectValueIwanttoDropdown(string value)
        {
            TALExtensions.SelectByValue(IwanttoDropdown, value);
        }
    }
}

