
Feature: Portfolio
	Adding and validating portfolio


Scenario Outline: Adding Portfolio
	Given Click on Add Portfolio and Add a new Portfolio
	And Fill the form "<Name>","<Client>","<Address1>","<Address2>","<Country>","<State>","<City>","<Postalcode>","<Latitude>","<Longitude>","<Timezone>"
	
Examples:
	| Name               | Client       | Address1     | Address2      | Country | State      | City    | Postalcode | Latitude  | Longitude | Timezone           |
	| Test_Demo_Porfolio1 | Test_CLient2 | Test_Address | Test_Address2 | India   | Tamil Nadu | Chennai | 603103     | 13.067439 | 13.067439 | (GMT+5:30) Chennai |


	#validate Portfolio
Scenario Outline: Validate Portfolio

	And Validate the existence of portfolio "<Name>"

Examples:
	| Name               |
	| Test_Demo_Portfolio1 |
	