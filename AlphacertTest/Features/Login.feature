Feature: AutombileInsurance
	

@Automobile @Positive
Scenario: Get the Quote of Automobile Insurance

	Given I visit to Tricentie website
	And I navigate to automobile isurance
	When I filled the required details and send teh quote
	Then I verify the quote is sent succesfully 
	
	