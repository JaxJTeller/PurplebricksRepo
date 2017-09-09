Feature: LoginToGmailAndSignOut

@mytag
Scenario: Goes to GMAIL page and I sign in; then I sign out
	Given I navigate to 'https://gmail.com'
	And I fill in the Email address 'andrei.gerosanu@gmail.com'
	And I fill in the account Password 'InsertPasswordHere'
	Then I click NEXT
	Then I click on the GMAIL profile icon to open its menu
	And I Sign Out