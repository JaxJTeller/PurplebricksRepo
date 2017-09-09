Feature: NonValidGMAIL

@mytag
Scenario: Goes to GMAIL sign in page and tries to create an account with an invalid email address

	Given I navigate to 'https://accounts.google.com/signup?hl=en-GB'
	And I enter 'Andrei' in the first name field
	And I enter 'Gerosanu' in the last name field
	And I enter 'username1988 which is invalid' in the mail username field
	Then The Warning Message 'Please use only letters (a-z), numbers and full stops.' For Invalid User Should Be Displayed 

Scenario: Goes to GMAIL sign in page and tries to create an account with an existing email address

	Given I navigate to 'https://accounts.google.com/signup?hl=en-GB'
	And I enter 'Andrei' in the first name field
	And I enter 'Gerosanu' in the last name field
	And I enter 'andrei.gerosanu' in the mail username field
	Then The Warning Message 'Someone already has that username. Note that we ignore full stops and capitalisation in usernames. Try another?' For Invalid User Should Be Displayed


	