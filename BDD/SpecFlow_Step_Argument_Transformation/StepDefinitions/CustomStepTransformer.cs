using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_Step_Argument_Transformation.StepDefinitions
{
    [Binding]
    public class CustomStepTransformer
    {
        [StepArgumentTransformation(@"(\d+) days from current date")]
        public DateTime DayAdderTransform(int days)
        {
           return DateTime.Today.AddDays(days);

        }
    }
}
