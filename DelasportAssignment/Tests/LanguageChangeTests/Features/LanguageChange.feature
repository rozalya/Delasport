Feature: LanguageChange


@mytag
Scenario: Change language to German
	Given the Country language is choosen
	When the site Language is changed

	Examples: 
	| Country | Language |
	| Deutsch |    de    |
	| Français|    fr    |
	| Italiano|    it    |
	| Español |    es    |
