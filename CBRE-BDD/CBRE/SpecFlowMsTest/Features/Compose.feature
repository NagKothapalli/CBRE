Feature: Compose
	I Will Write All Compose Scenarios in this Feature

@Smoke @Regression
Scenario: Compose And Send An Email With Attachment
 I Will be Sending An Email To My Friend with Attachment
	Given I Launch And Login To Gmail Application
	When I Compose And Send An Email
	Then The Email Should be Sent Successfully

@Regression
Scenario: Compose And Send An Email WithOut Attachment
 I Will be Sending An Email To My Friend with Attachment
	Given I Launch And Login To Gmail Application
	When I Compose And Send An Email Without Attachment
	Then The Email Should be Sent Successfully

@Search
Scenario: Search An Email
Given I Launch And Login To Gmail Application
When I Search With Subject 'Nukari'
Then I Should See All Monster Emails
@DataDriven
Scenario Outline: Search An Eamil DataDriven
Given I Launch And Login To Gmail Application
When I Search With Subject "<Subject>" and "<From>"
Then I Should See All Monster Emails
Examples: 
| Subject  | From |
| Java     | NCR  |
| C#       | CBRE |
| Selenium | ADP  |
