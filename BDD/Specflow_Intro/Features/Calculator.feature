Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlow_Intro/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@SmokeTest
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Create a new employee with mandatory details
	#Given I have opened my application
	#Then I should see employee details page
	When I fill all the mandatory details in form
	| Name    | Age | Phone      | Email                         |
	| karthik | 28  | 9098023842 | karthik@executeautomation.com |
	| john	  | 30  | 9098023843 | john@executeautomation.com	 |
	| sam	  | 28  | 9098023844 | sam@executeautomation.com	 |
	#And I click the save button
	#Then I should see all the details saved in my application and DB

Scenario Outline: Create a new employee with mandatory details for different iteration
	#Given I have opened my application
	#Then I should see employee details page
	When I fill all the mandatory details in form <Name>, <Age> and <Phone>
	#And I click the save button
	#Then I should see all the details saved in my application and DB
Examples: 
	| Name    | Age | Phone      | 
	| karthik | 28  | 9098023842 |
	| john    | 30  | 9098023843 |
	| sam     | 28  | 9098023844 |

Scenario: Check if I could get the details entered via Table from Extended Steps
	When I fill all the mandatory details in form
	| Name    | Age | Phone      | Email             |
	| karthik | 28  | 1234567890 | karthik@gmail.com |
	Then I should get the same value from Extended steps