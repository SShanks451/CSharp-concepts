using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UserApi.Api.Controllers;

namespace UserApi.Tests
{
    [Binding]
    public class UpdateUserFeatureSteps
    {
        ScenarioContext context = ScenarioContext.Current;

        [When(@"I request to update the user by Id with details")]
        public void WhenIRequestToUpdateTheUserByIdWithDetails(Table table)
        {
            var updateData = table.CreateInstance<UpdateUserDataTable>();
            var usersController = context.Get<UsersController>();
            var response = usersController.UpdateUser(1, updateData.Name, updateData.Surname, updateData.Email);
            context.Set(response);
        }

        [Then(@"the user should be updated")]
        public void ThenTheUserShouldBeUpdated()
        {
            var response = context.Get<IHttpActionResult>();
            var resp = response as OkResult;
            Assert.IsNotNull(resp);
        }

        [When(@"I request to update the user by Id with details Name: '(.*)' Surname: '(.*)' and Email: '(.*)'")]
        public void WhenIRequestToUpdateTheUserByIdWithDetailsNameSurnameAndEmail(string testName, string testSurname, string testEmail)
        {
            var usersController = context.Get<UsersController>();
            var response = usersController.UpdateUser(1, testName, testSurname, testEmail);
            context.Set(response);
        }
    }

    class UpdateUserDataTable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
