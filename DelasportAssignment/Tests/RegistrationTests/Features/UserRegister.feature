Feature: UserRegister
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@CreateUser
Scenario: Registeration data in first step can be filled in
	Given Registeration screen is opend
	When the data is filled in	
	| Email       | Username | Password |
	| test@abv.bg | user1    | 123      |

@CreateUser
Scenario: Registeration data in first step with invalid email
	Given Registeration screen is opend
	When the data is filled in	
	| Email    |
	|          |
	Then Error message is displayed

@CreateUser
	Scenario: Registeration data in first step without username
	Given Registeration screen is opend
	When the data is filled in	
	 | Username |
	 |          |
	Then Error message for missing usernme is displayed

@CreateUser
Scenario: Registeration data in first step without password
	Given Registeration screen is opend
	When the data is filled in	
	| Password |
	|          |
	Then Error message for missing password is displayed
