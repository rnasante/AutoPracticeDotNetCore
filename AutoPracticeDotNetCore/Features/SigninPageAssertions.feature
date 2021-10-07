Feature: SigninPageAssertions
	As a user I want the right error messages to be dispalyed when
	invalid Sign in details are entered.


Scenario Outline: Sign In Page Assertions - Failures
	Given I navigate to Automation Practice Homepage
	And I click on Sign in link 
	When I enter "<Email>" at email address textbox
	And I enter "<Password>" at password 
	When I click on Sign in button
	Then the error message reads "<Error message>"

Examples: 
       | Email               | Password | Error message                |
       | raynice54@gmail.com | sixty7   | Authentication failed        |
       | raynice54@gmail.com |          | Password is required         |
       |                     | sixty7   | An email address required    |
       |                     |          | An email address required    |