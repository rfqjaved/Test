
Feature: Add Client
	Add CLient and Validate 

#Creating a client

Scenario Outline:Adding Client
	Given the environment
	And Enter the userName
	And Enter Password
	Then Click on Login
	And validate the login condition
	Then Click on Add Client and Add a new client
	And Fill the client Form "<Name>","<Account>", "<Comment>","<Address1>","<Address2>","<Country>","<State>","<City>","<Postalcode>"

Examples: 
	| Name         | Account     | Comment                 | Address1        | Address2 | Country | State      | City    | Postalcode |
	| Test_CLient2 | 3Degrees AR | Demo CLient Preparation | Randome adress1 | Adress2  | India   | Tamil Nadu | Chennai | 603103     |


#validating a created client

Scenario Outline:Validating Client
	Given Click on Manage Client 
	And Validate the Client information"<Name>"

Examples: 
	| Name         |
	| Test_CLient2 | 



	

	