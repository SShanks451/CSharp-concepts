using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingFeatureStepsAndScenarioInfo
{
    [Binding]
    public class GeneralHook
    {
        [AfterStep]
        public void AfterScenario()
        {
            var featureTitle = FeatureContext.Current.FeatureInfo.Title;
            var scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;
            var scenarioTag = ScenarioContext.Current.ScenarioInfo.Tags;
            var stepInfo = ScenarioContext.Current.StepContext.StepInfo.Text;

            Console.WriteLine($"FeatureTitle: {featureTitle} and ScenarioTitle: {scenarioTitle} with scenarioTag: {scenarioTag.First()}");
            Console.WriteLine($"Step: {stepInfo}");
        }
    }
}
