using System;
using TechTalk.SpecFlow;

namespace SpecFlow_Intro.StepDefinitions
{
    [Binding]
    public class ExtendedSteps
    {
        public readonly EmployeeDetails employee;

        public ExtendedSteps(EmployeeDetails emp)
        {
            this.employee = emp;
        }


        [Then(@"I should get the same value from Extended steps")]
        public void ThenIShouldGetTheSameValueFromExtendedSteps()
        {
            Console.WriteLine(employee.Age);
            Console.WriteLine(employee.Email);
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Phone);
        }

    }
}
