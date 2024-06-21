using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_Bindings.StepDefinitions
{
    [Binding]
    public class Login
    {
        [Given(@"I have opened the applicaition")]
        public void GivenIHaveOpenedTheApplicaition()
        {
            throw new PendingStepException();
        }

        [Given(@"I login to application")]
        [Scope(Feature = "Customer_Login")]
        public void GivenILoginToApplication()
        {
            throw new PendingStepException();
        }

        [Then(@"I see customer portal")]
        public void ThenISeeCustomerPortal()
        {
            throw new PendingStepException();
        }

        [Then(@"I see user portal")]
        public void ThenISeeUserPortal()
        {
            throw new PendingStepException();
        }
    }
}
