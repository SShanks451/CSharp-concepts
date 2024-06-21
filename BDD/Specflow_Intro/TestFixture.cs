using TechTalk.SpecFlow;

namespace SpecFlow_Intro
{
    [Binding]
    public sealed class TestFixture
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.WriteLine("calling before feature");
        }

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("calling before scenario");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("calling after scenario");
        }
    }
}