# Generates the Specflow test report

$RootPath = (get-item $PSScriptRoot ).parent.FullName
$Timestamp = Get-Date -format yyyy-M-d_HH-mm
$Test_Results= "TestResults/results.xml"
$Test_Output= "TestResults/output.txt"
$SpecflowReport = "TestResults/TestReport-$Timestamp.html"
$Test_Project = "$RootPath\QAWorks.Website.SmokeTests\QAWorks.Website.SmokeTests.csproj"
$Specflow_exe = "$RootPath\packages\SpecFlow.2.2.0\tools\specflow.exe"

Start-Process $Specflow_exe "nunitexecutionreport $Test_Project /out:$SpecflowReport /xmlTestResult:$Test_Results /testOutput:$Test_Output"
