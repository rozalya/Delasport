Feature: RegisterUserThirdStep

Background: 
		Given Registeration screen is opend


@CreateUser
Scenario: Register user seccesfully
	And The first step of registartion is compleated
   When the person data is filled in	
	| Gender   | TermsAndConditions  | NewsLetter   |
	| <Gender> |<TermsAndConditions> | <NewsLetter> |
 Then new account is created



Examples: 
| Gender  |TermsAndConditions | NewsLetter |
| female  |        true       |      true  |
| male    |       true        |      true  |