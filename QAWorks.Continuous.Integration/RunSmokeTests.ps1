# Runs the smoke tests and captures the test results for reporting
# Note: the nunit xml output from nunit3 console tool is written in nunit2 format for backwards compatability with Specflow reporting tool
# Filters on @ContactUs test scenarios 

$RootPath = (get-item $PSScriptRoot ).parent.FullName
$ChromeDriverPath = "$RootPath\QAWorks.Website.SmokeTests\bin\Debug\chromedriver.exe"

if(![System.IO.File]::Exists($ChromeDriverPath)){
    # copy the chrome driver to the test bin folder
	Copy-Item -Path $RootPath\packages\Selenium.WebDriver.ChromeDriver.2.32.0\driver\win32\chromedriver.exe -Destination $RootPath\QAWorks.Website.SmokeTests\bin\Debug
}

$result = "TestResults\results.xml;format=nunit2"
$out = "TestResults\output.txt"
$Nunit_Console = "$RootPath\packages\NUnit.ConsoleRunner.3.7.0\tools\nunit3-console.exe"
$Filter = "--where cat=ContactUsPage"

$arguments = "$RootPath\QAWorks.Website.SmokeTests\bin\Debug\QAWorks.Website.SmokeTests.dll --out=$out --result=$result $Filter"

Start-Process $Nunit_Console $arguments 
