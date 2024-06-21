using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_Bindings.StepDefinitions
{
    [Binding]
    public class UserLoginStep
    {
        [Given(@"I login to application")]
        [Scope(Feature = "User_Login")]
        public void GivenILoginToApplication()
        {
            throw new PendingStepException();
        }
    }
}
