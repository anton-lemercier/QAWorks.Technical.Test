# ReadMe - QAWorks Technical Test
### Anton LeMercier - QAWorks Technical Test 

## Instructions

#### Build the solution 
* Clone the repository and open the solution in Visual Studio
* Use the package manager console to restore the package dependencies
* Build the solution

#### Run the automated tests
* In solution explorer navigate to the QAWorks.Continuous.Integration project within the CI folder
* Right-click on the project and select Open Folder In File Explorer from the context menu
* In the file explorer right-click the PowerShell script RunSmokeTests.ps1 and select Run With PowerShell from the context menu
* The tests will run

#### Generate the test report
* Generate the test report by right-clicking on the PowerShell script GenerateTestReport.ps1 and selecting Run with PowerShell from the context menu
* The report will be generated in the adjacent TestResults folder
* To view the report, open the TestResults folder and double-click the file TestReport-[timestamp].html to open the report in a browser

## Platform limitations
* The test will only run on a windows platform and targets version 4.6.1 of the .Net framework
* The tests only run the Chrome browser
* The CI scripts are written PowerShell so require PowerShell to execute

## Dependencies
* Specflow 2.2.0
* Nunit 3.0
* Coypu 2.1
* Webdriver 2.48

## Highlights
* Strong focus on separation of concerns and loose coupling so the web driver implementation can be 'swapped' out using interfaces and dependency injection
* Use of the internal Specflow DI framework to inject page models into step files
* Driver factory implementation to facilitate test execution against different devices through configuration parameters in the CI pipelines
[although commented out - suspect a Selenium version issue]
* Page model object pattern acts as the communication channel between the tests and the web driver - improves flexible coupling and maintainability
* Use of Coypu library to help with inherent problems of the native Selenium driver with regard to waiting for elements etc.
* Use of Specflow helpers to cast data table into custom objects
* Pause mechanism allows delays to be handled on case by case basis by the page object models
* Category filter on the test run scripts allow CI to be selective in which tests they run
* Specflow reporting 

## Improvements 
* Deployment of the Chromedriver.exe could be more robust. Currently copied to the bin folder
* Use of Xpath to identify and target the ContactUs menu item which is very brittle and should use element ids
* Use of validation message strings in Assertions can be brittle and problematic
* Scenarios are imperative... could be more declarative by moving the data to external configuration files
 
## Bugs
* Scenario to test that only valid email addresses should be submitted failed. The validation is applied on blur of the email input box but is not re-applied on form submission, therefore the tests could send an invalid email address to the server. As no server side validation is applied to the email address a 500 server error occurs. "The specified string is not in the form required for an e-mail address".

* Not really a bug, but there is no visual cue to the user that the contact form had been sent successfully, so leaves the user with potential uncertainty that the message might not be received. As well as a poor user experience this made it difficult to verify that the message had been sent, the only elements to assert on are the input elements are cleared.
