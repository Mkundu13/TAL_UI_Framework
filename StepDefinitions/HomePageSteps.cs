using TAL_UI_Framework.Drivers;
using TAL_UI_Framework.Pages;

namespace TAL_UI_Framework.StepDefinitions
{
    [Binding]
    public class HomePageSteps
    {

        private DriverHelper _driverHelper;
        HomePage homePage;
        public HomePageSteps(DriverHelper driverHelper )
        {
            _driverHelper = driverHelper;
            homePage = new HomePage(_driverHelper.Driver);
        }

        [Given(@"The user clicks on the Contact us link in the footer")]
        public void GivenTheUserClicksOnTheContactUsLinkInTheFooter()
        {
            homePage.ClickContactUsFooter();
        }


        [Given(@"The user clicks on the insurance-products on Home page")]
        public void GivenTheUserClicksOnTheInsurance_ProductsOnHomePage()
        {
            homePage.ClickInsuranceProducts();
        }

        [Given(@"The user selects the option Life insurance under insurance-products")]
        public void GivenTheUserSelectsTheOptionLifeInsuranceUnderInsurance_Products()
        {
            homePage.ClickLifeInsurance();
        }


        [Given(@"The user clicks on the Claims on Home page")]
        public void GivenTheUserClicksOnTheClaimsOnHomePage()
        {
            homePage.ClickClaims();
        }


        [Given(@"The user selects the option Claims under Claims")]
        public void GivenTheUserSelectsTheOptionClaimsUnderClaims()
        {
            homePage.ClickClaimsUnderClaims();
        }
    }
}