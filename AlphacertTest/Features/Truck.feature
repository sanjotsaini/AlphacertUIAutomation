Feature: Truck
	

@Positive @Truck
Scenario: Get The Quote of Truck Insurance
	Given I visit to Tricentie website
	When I navigate to truck isurance
	When I fill the vehicle data details truck
	| Field              | Values     |
	| Make               | BMW        |
	| EnginePerformance  | 236        |
	| DateOfManufacture  | 02/04/2007 |
	| NumberOfSeats      | 5          |
	| FuelType           | Petrol     |
	| Payload            | 500        |
	| TotalWeight        | 500        |
	| ListPrice          | 50000      |
	| LicencePlateNumber | LSU335     |
	| AnualMilage        | 300        |		
	When I fill the insurance data details 
	| Field         | Values            |
	| FirstName     | Sanjot            |
	| LastName      | Saini             |
	| DOB           | 12/26/1993        |
	| Gender        | Male              |
	| StreetAddress | 39,Magnolia drive |
	| Country       | New Zealand       |
	| ZipCode       | 4310              |
	| City          | New Plymouth      |
	| Occupation    | Farmer            |
	| Hobbies       | SkyDiving         |
	| Website       |https://facebook.com|
	When I fill the enter product data details for truck
	| Field            | Values        |
	| StartDate        | 05/03/2021    |
	| InsurancSum      | 7.000.000,00  |
	| MeritRating      | Bonus 7       |
	| DamageInsurance  | Full Coverage |
	| OptionalProducts |               |
	| CourtesyCar      | Yes           |
	When  I select the price option
	When I fill the send qoute details
	| Field           | Values                  |
	| Email           | sainisanjot26@gmail.com |
	| Username        | sainisa                 |
	| Password        | Password@123            |
	| ConfirmPassword | Password@123            |
	| Comment         | Test                    |		
	When I click the send button
	Then I verify the quote is sent succesfully 