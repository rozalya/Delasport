Feature: RegisterUserSecondStep

Background: 
		Given Registeration screen is opend
		And The first step of registartion is compleated


Scenario Outline: Registeration data in second step without firstName
	Given the second screen is opened
	When the person data is filled in	
	| Gender   | FirstName  | TermsAndConditions  | NewsLetter   |
	| <Gender> | <FirstName>|<TermsAndConditions> | <NewsLetter> |
	Then Error message for missing first name is displayed

Examples: 
| Gender | FirstName |TermsAndConditions | NewsLetter |
| female |           |        true       |      true  |
| male   |           |       true        |      true  |




Scenario Outline: Registeration data in second step without last name
	Given the second screen is opened
	When the person data is filled in	
| Gender   | FirstName  | TermsAndConditions  | NewsLetter   |
| <Gender> | <FirstName>|<TermsAndConditions> | <NewsLetter> |	
	Then Error message for missing last name is displayed

Examples: 
| Gender  | LastName  | TermsAndConditions | NewsLetter |
| female  |           |         true       |      true  |
| male    |           |        true        |      true  |




Scenario Outline: Registeration data in second step without cell phone
	Given the second screen is opened
	When the person data is filled in	
| Gender   | FirstName  | TermsAndConditions  | NewsLetter   |
| <Gender> | <FirstName>|<TermsAndConditions> | <NewsLetter> |

	Then Error message for missing cell phone is displayed

Examples: 
| Gender | CellPhone | TermsAndConditions | NewsLetter |
| female |           |         true       |      true  |
| male   |           |        true        |      true  |


Scenario Outline: Registeration data in second step without accept the terms and conditions
	Given the second screen is opened
	When the person data is filled in	
| Gender   | FirstName  | TermsAndConditions  | NewsLetter   |
| <Gender> | <FirstName>|<TermsAndConditions> | <NewsLetter> |

	Then Error message for not accept the terms and conditions

Examples: 
| Gender |TermsAndConditions | NewsLetter |
| female |        false      |      true  |
| male   |       false       |      true  |