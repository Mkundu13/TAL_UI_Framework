Feature: TALTestCases


#Steps for this test case are not clear, not able to find on website 
Scenario: Test 1 Making a Claim
	Given The user clicks on the Claims on Home page
	And The user selects the option Claims under Claims
	When The user selects RecoveryTraumaInsurance option
	And The user selects the option make a Claim, on Claims page 


Scenario: Test 2 Searching for a Life Insurance Product
	Given The user clicks on the insurance-products on Home page
	And The user selects the option Life insurance under insurance-products
	When The user selects the option Get a quote on lifeinsurance page 
	And The user fills the life insurance page with below options
		| DOB          | Occupation          | AnnualIncome |
		| "10/08/1982" | Doctor - Specialist | "220000"     |
	And the user enters the life insurance page with below options
		| FirstName | LastName | Phone        | Email         | PostCode |
		| Manoj     | Kumar    | "0414866580" | mkk@gmail.com | "3027"   |
	And The user selects Life Insurance Plan as Add a benefit to get started  
	And The user enters the Cover Amount of 500000
	And The user clicks on the Confirm button
	And The user clicks on the Continue button
	Then Verify we get the "Your chosen benefits at a glance" message 


#This test case got CAPTCHA, which cannot be automated so it will fail. 	
Scenario: Test 3 Contacting TAL Customer Service
	Given The user clicks on the Contact us link in the footer  
	When The user fill the Contact us page with below values
	| Name  | Email        | Phone      | Query            |
	| Manoj | mk@gmail.com | 0414866580 | This is my query |
	And The user selects the value "Make a general enquiry" from the IwanttoDropdown
	And The user checks the i'm not a robot captch 
	And The user click on the send message button
	Then The user should see the message "Thank you for getting in touch with us." message