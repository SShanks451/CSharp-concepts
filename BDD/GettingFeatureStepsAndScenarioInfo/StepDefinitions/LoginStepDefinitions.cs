using System;
using TechTalk.SpecFlow;

namespace GettingFeatureStepsAndScenarioInfo.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            Console.WriteLine("Demo step");
        }

        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            Console.WriteLine("Demo step");
        }

        [Then(@"I click login link")]
        public void ThenIClickLoginLink()
        {
            Console.WriteLine("Demo step");
        }

        [When(@"I enter UserName and Password")]
        public void WhenIEnterUserNameAndPassword(Table table)
        {
            Console.WriteLine("Demo step");
        }

        [Then(@"I click login button")]
        public void ThenIClickLoginButton()
        {
            Console.WriteLine("Demo step");
        }

        [Then(@"I should see the username with hello")]
        public void ThenIShouldSeeTheUsernameWithHello()
        {
            Console.WriteLine("Demo step");
        }

        [Then(@"I click logout")]
        public void ThenIClickLogout()
        {
            Console.WriteLine("Demo step");
        }
    }
}
