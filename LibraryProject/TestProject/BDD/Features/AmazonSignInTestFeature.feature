Feature: Amazon LogIn Test Feature

@AmazonLoginIn
Scenario: Verifying the functionality of amazon login with incorrect credentials
	Given User is on the page https://www.amazon.in/
	When User clicks on the signIn button
	And User enters the email/mobile number and clicks continue
	And User enters the password ans clicks signIn
	Then LogIn unsuccessful message is displayed