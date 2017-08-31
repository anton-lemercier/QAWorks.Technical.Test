﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace QAWorks.Website.SmokeTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Contact Us Page")]
    [NUnit.Framework.CategoryAttribute("ContactUsPage")]
    public partial class ContactUsPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ContactUs.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Contact Us Page", "  As an end user\r\n  I want a contact us page\r\n  So that I can find out more about" +
                    " QAWorks exciting services", ProgrammingLanguage.CSharp, new string[] {
                        "ContactUsPage"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Send a valid contact request for more information")]
        public virtual void SendAValidContactRequestForMoreInformation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send a valid contact request for more information", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
testRunner.Given("I am on the QAWorks Site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
testRunner.And("I have navigated to the contact us page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "email",
                        "message"});
            table1.AddRow(new string[] {
                        "j.Bloggs",
                        "j.Bloggs@qaworks.com",
                        "[Technical Test - Please Ignore] Please contact me I want to find out more"});
#line 10
testRunner.When("I send a request for more information with valid details", ((string)(null)), table1, "When ");
#line 13
testRunner.Then("the contact request should be sent successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Name is mandatory")]
        public virtual void NameIsMandatory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Name is mandatory", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
testRunner.Given("I am on the QAWorks Site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
testRunner.And("I have navigated to the contact us page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "email",
                        "message"});
            table2.AddRow(new string[] {
                        "",
                        "j.Bloggs@qaworks.com",
                        "[Technical Test - Please Ignore] Please contact me I want to find out more"});
#line 18
testRunner.When("I attempt to send a request for more information without a name", ((string)(null)), table2, "When ");
#line 21
testRunner.Then("I should be informed that I must provide my name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Email address is mandatory")]
        public virtual void EmailAddressIsMandatory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Email address is mandatory", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
testRunner.Given("I am on the QAWorks Site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
testRunner.And("I have navigated to the contact us page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "email",
                        "message"});
            table3.AddRow(new string[] {
                        "j.Bloggs",
                        "",
                        "[Technical Test - Please Ignore] Please contact me I want to find out more"});
#line 26
testRunner.When("I attempt to send a request for more information without an email address", ((string)(null)), table3, "When ");
#line 29
testRunner.Then("I should be informed that I must provide an email address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Message is mandatory")]
        public virtual void MessageIsMandatory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Message is mandatory", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
testRunner.Given("I am on the QAWorks Site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
testRunner.And("I have navigated to the contact us page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "email",
                        "message"});
            table4.AddRow(new string[] {
                        "j.Bloggs",
                        "j.Bloggs@qaworks.com",
                        ""});
#line 34
testRunner.When("I attempt to send a request for more information without a message", ((string)(null)), table4, "When ");
#line 37
testRunner.Then("I should be informed that I must enter a message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Email address must be valid")]
        public virtual void EmailAddressMustBeValid()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Email address must be valid", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line 40
testRunner.Given("I am on the QAWorks Site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
testRunner.And("I have navigated to the contact us page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "email",
                        "message"});
            table5.AddRow(new string[] {
                        "j.Bloggs",
                        "InvalidEmailAddress",
                        "[Technical Test - Please Ignore] Please contact me I want to find out more"});
#line 42
testRunner.When("I attempt to send a request for more information with an invalid email address", ((string)(null)), table5, "When ");
#line 45
testRunner.Then("I should be informed that I must provide a valid email address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
