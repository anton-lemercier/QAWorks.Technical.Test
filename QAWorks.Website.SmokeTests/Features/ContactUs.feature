@ContactUsPage
Feature: Contact Us Page
  As an end user
  I want a contact us page
  So that I can find out more about QAWorks exciting services

Scenario: Send a valid contact request for more information
Given I am on the QAWorks Site
And I have navigated to the contact us page
When I send a request for more information with valid details
 | name     | email                | message                                   |
 | j.Bloggs | j.Bloggs@qaworks.com | [Technical Test - Please Ignore] Please contact me I want to find out more |
Then the contact request should be sent successfully 

Scenario: Name is mandatory
Given I am on the QAWorks Site
And I have navigated to the contact us page
When I attempt to send a request for more information without a name
| name | email                | message                                                                    |
|      | j.Bloggs@qaworks.com | [Technical Test - Please Ignore] Please contact me I want to find out more |
Then I should be informed that I must provide my name

Scenario: Email address is mandatory
Given I am on the QAWorks Site
And I have navigated to the contact us page
When I attempt to send a request for more information without an email address
| name     | email | message                                                                    |
| j.Bloggs |       | [Technical Test - Please Ignore] Please contact me I want to find out more |
Then I should be informed that I must provide an email address

Scenario: Message is mandatory
Given I am on the QAWorks Site
And I have navigated to the contact us page
When I attempt to send a request for more information without a message
| name     | email                | message |
| j.Bloggs | j.Bloggs@qaworks.com |         |
Then I should be informed that I must enter a message

Scenario: Email address must be valid
Given I am on the QAWorks Site
And I have navigated to the contact us page
When I attempt to send a request for more information with an invalid email address
| name     | email               | message                                                                    |
| j.Bloggs | InvalidEmailAddress | [Technical Test - Please Ignore] Please contact me I want to find out more |
Then I should be informed that I must provide a valid email address