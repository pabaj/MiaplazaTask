Feature: MOHS IntialApplication

Sceanrios related to the MOHS Application filling and submitting.

@MOHSInitialApplication
Scenario: User Fill out Parent infromation in MOHS Intial Application
	Given Navigate to Miacademy page 
	When  Navigate to online high school and apply to school
	And   Fill Out parent information and navigate to next page 
	| FirstName | Lastname | Email               | PhoneNumber  | SecondParent |
	| Susanne   | Wright   | susannewh@hmail.com | 152324523455 | No           |
	Then  Verify User navigate to Student Information Page
