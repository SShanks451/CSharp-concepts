Feature: Customer_Login

simple feature to demonstrate customer login feature

@customer
Scenario: Login for customer portal
	Given I have opened the applicaition
	And I login to application
	Then I see customer portal
	