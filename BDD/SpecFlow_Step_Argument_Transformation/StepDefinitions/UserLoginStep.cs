using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace SpecFlow_Step_Argument_Transformation.StepDefinitions
{
    [Binding]
    public class UserLoginStep
    {
        [Given(@"I have opened the application")]
        public void GivenIHaveOpenedTheApplication()
        {
            Console.WriteLine("Opened the application");
        }

        [Given(@"I login to application as admin")]
        public void GivenILoginToApplicationAsAdmin()
        {
            Console.WriteLine("Logged in as admin");
        }

        [Then(@"I see last date logged in data is (.* days from current date)")]
        public void ThenISeeLastDateLoggedInDataIsDaysFromCurrentDate(DateTime correctDateTime)
        {
            Console.WriteLine(correctDateTime);
        }

        [Then(@"I see the menus like")]
        public void ThenISeeTheMenusLike(IEnumerable<dynamic> menuList)
        {
            var menu = menuList.First();

            string menu1 = menu.Menu_1;
            string menu2 = menu.Menu_2;

            Console.WriteLine("The value of Menu1 is {0} and the value of Menu2 is {1}", menu1, menu2);
        }


    }
}
