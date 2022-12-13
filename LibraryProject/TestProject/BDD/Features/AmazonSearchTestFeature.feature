Feature: Amazon Search Bar Test Feature


@AmazonSearchBar
Scenario: Verifying the functionality of amazon search bar
	Given User is on the home page
	When User enters the item to search on the amazon search bar
	And User clicks on the search button
	Then Searched item get populated