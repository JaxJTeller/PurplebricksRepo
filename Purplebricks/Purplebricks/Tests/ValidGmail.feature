Feature: ValidGmail


@mytag
Scenario: Goes go GMAIL sign in page and creates a valid account but invalid SMS at the end of the flow
	Given I navigate to 'https://accounts.google.com/signup?hl=en-GB'
	And I enter 'Andrei' in the first name field
	And I enter 'Gerosanu' in the last name field
	And I enter 'Purplebricks1988' in the mail username field
	And I enter 'PassForever123' in the Create a password field
	And I enter 'PassForever123' in the Confirm your password field
	And I enter '21' in the Birthday Field
	And I enter 'June' in the Month dropdown
	And I enter '1988' in the Year field
	And I enter 'Male' in the Gender dropdown
	And I click Next step
	And I click the scroll down arrow
	And I click Agree
	Then The warning message 'Verify your account' should be displayed
	And I enter '641281659' in the phone number field
	And I click Continue
	Then The warning message 'Verify your account' should be displayed
	And I enter 'SMS' in the SMS code
	And I click Continue after introducing SMS code
	Then I click Continue on the Welcome screen
	Then To continue reintroduce password 'PassForever123'
	And I click NEXT

