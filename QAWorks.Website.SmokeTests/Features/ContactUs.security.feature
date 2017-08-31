# This test has not been run - respecting that this is a live site and such tests require approval and permission
@Security
Feature: Contact Us Page Security
  As a security engineer
  I want to ensure that the contact us form is secure
  So that QAWorks are protected from injection attacks

@ignore
Scenario: Send a script in the message field
Given I am on the QAWorks Site
And I have navigated to the contact us page
When I send a request for more information with scripting in the message  
 | name     | email                | message                                   |
 | j.Bloggs | j.Bloggs@qaworks.com | [Technical Test - Please Ignore]  <script>alert('you have been hacked')</script> |
Then the contact request should be rejected  

# repeat for SQL injection


