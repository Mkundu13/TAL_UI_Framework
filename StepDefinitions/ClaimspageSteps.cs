using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAL_UI_Framework.Drivers;
using TAL_UI_Framework.Pages;

namespace TAL_UI_Framework.StepDefinitions
{
    [Binding]
    public class ClaimspageSteps
    {

        private DriverHelper _driverHelper;
        Claimspage claimspage;

        public ClaimspageSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            claimspage = new Claimspage(_driverHelper.Driver);
        }

        [When(@"The user selects the option make a Claim, on Claims page")]
        public void WhenTheUserSelectsTheOptionMakeAClaimOnClaimsPage()
        {
            claimspage.ClickMakeaClaim();
        }

        [When(@"The user selects RecoveryTraumaInsurance option")]
        public void WhenTheUserSelectsRecoveryTraumaInsuranceOption()
        {
            claimspage.ClickRecoveryTraumaInsurance();
        }
    }
}
