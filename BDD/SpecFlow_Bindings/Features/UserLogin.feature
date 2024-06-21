Feature: User_Login

Simple feature to demonstrate user login feature

@user
Scenario: Login for user portal
	Given I have opened the application
	And I login to application
	Then I see user portal
