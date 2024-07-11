using TechTalk.SpecFlow;

namespace SpecFlow_Intro
{
    [Binding]
    public sealed class TestFixture
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public static void BeforeScenario()
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