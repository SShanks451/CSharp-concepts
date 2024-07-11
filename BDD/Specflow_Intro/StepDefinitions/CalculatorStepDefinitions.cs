using NUnit.Framework.Constraints;
using TechTalk.SpecFlow.Assist;

namespace SpecFlow_Intro.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        public readonly EmployeeDetails employee;
        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(EmployeeDetails emp, ScenarioContext scenarioContext)
        {
            this.employee = emp;
            this._scenarioContext = scenarioContext;
        }


        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            Console.WriteLine($"{nameof(GivenTheFirstNumberIs)} : {number}");
        }

        
        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            Console.WriteLine($"{nameof(GivenTheSecondNumberIs)} : {number}");
        }
        

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine("Pressed Add Button");
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            if(result == 120) // grab the object which has the value 120 in the UI of yut application and replace that
            {
                Console.WriteLine("The test PASSED");
            }else
            {
                Console.WriteLine("The test FAILED");
                throw new Exception("Value is different");
            }
        }

        [When(@"I fill all the mandatory details in form")]
        public void WhenIFillAllTheMandatoryDetailsInForm(Table table)
        {
            /*
            If table had a single row 

            var details = table.CreateInstance<EmployeeDetails>();
            */

            /*
            var details = table.CreateSet<EmployeeDetails>();

            foreach (EmployeeDetails emp in details)
            {
                Console.WriteLine("The details of employee : " + emp.Name);
                Console.WriteLine("******************************************************");
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Email);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Phone);
            }
            */

            //-----------------------------------------------------------------------------------------

            /*
            // Work with Dynamic Assist

            var details = table.CreateDynamicSet();
            
            // Iterate 
            foreach (var emp in details)
            {
                Console.WriteLine("The details of employee : " + emp.Name);
                Console.WriteLine("******************************************************");
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Email);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Phone);
            }
            */

            //-----------------------------------------------------------------------------------------


            var data = table.CreateDynamicSet();
            foreach (var item in data)
            {
                employee.Age = (int)item.Age;
                employee.Name = (string)item.Name;
                employee.Email = (string)item.Email;
                employee.Phone = (long)item.Phone;
            }

        }

        [When(@"I fill all the mandatory details in form (.*), (.*) and (.*)")]
        public void WhenIFillAllTheMandatoryDetailsInForm(string name, int age, Int64 phone)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone: " + phone);

            _scenarioContext["InfoForNextStep"] = "Step1 Passed";
            Console.WriteLine(_scenarioContext["InfoForNextStep"].ToString());

            List<EmployeeDetails> empDetails = new List<EmployeeDetails>()
            {
                new EmployeeDetails()
                {
                    Name = "Abraham",
                    Age = 20,
                    Email = "abraham@gmail.com",
                    Phone = 123123123
                },
                new EmployeeDetails()
                {
                    Name = "Mike",
                    Age = 20,
                    Email = "mike@gmail.com",
                    Phone = 123123123
                },
                new EmployeeDetails()
                {
                    Name = "Jacob",
                    Age = 33,
                    Email = "jacob@gmail.com",
                    Phone = 123123123
                }
            };

            // Save the value in ScenarioContext
            _scenarioContext.Add("EmpDetails", empDetails);

            // Get the value out from Scenario Context
            var emplist = _scenarioContext.Get<IEnumerable<EmployeeDetails>>("EmpDetails");
            foreach (EmployeeDetails emp in emplist)
            {
                Console.WriteLine("The Employee name is " + emp.Name);
                Console.WriteLine("The Employee age is " + emp.Age);
                Console.WriteLine("The Employee email is " + emp.Email);
                Console.WriteLine("The Employee phone is " + emp.Phone);
                Console.WriteLine("\n");
            }
        

            Console.WriteLine(_scenarioContext.ScenarioInfo.Title);
            Console.WriteLine(_scenarioContext.Count);
            Console.WriteLine(_scenarioContext.CurrentScenarioBlock);
        }

    }
}
