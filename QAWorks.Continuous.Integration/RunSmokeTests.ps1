# Runs the smoke tests and captures the test results for reporting
# Note: the nunit xml output from nunit3 console tool is written in nunit2 format for backwards compatability with Specflow reporting tool
# Filters on @ContactUs test scenarios 

$RootPath = (get-item $PSScriptRoot ).parent.FullName
$result = "TestResults\results.xml;format=nunit2"
$out = "TestResults\output.txt"
$Nunit_Console = "$RootPath\packages\NUnit.ConsoleRunner.3.7.0\tools\nunit3-console.exe"
$Filter = "--where cat=ContactUsPage"

$arguments = "$RootPath\QAWorks.Website.SmokeTests\bin\Debug\QAWorks.Website.SmokeTests.dll --out=$out --result=$result $Filter"

Start-Process $Nunit_Console $arguments 
