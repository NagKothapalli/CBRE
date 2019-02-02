Feature: Sent
	I Will Write All Scenarios from Sent Module

@Smoke @Regression
Scenario: SeeAllSentEmail
	Given I Launch And Login To Gmail Application
	When I Navigate To Sent Items
	Then I Should See All Sent Mails
 @Regression
Scenario: See All SentEmails With Attachments
	Given I Launch And Login To Gmail Application
	When I Navigate To Sent Items
	Then I Should See All Sent Mails With Attachment
