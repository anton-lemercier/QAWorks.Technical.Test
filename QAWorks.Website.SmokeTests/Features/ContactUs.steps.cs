using NUnit.Framework;
using QAWorks.Website.SmokeTests.DataModels;
using QAWorks.Website.SmokeTests.PageModels;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace QAWorks.Website.SmokeTests.Features
{
    [Binding]
    public class ContactUs
    {
        private readonly HomePageModel _homePage;
        private readonly ContactUsPageModel _contactUsPage;

        public ContactUs(HomePageModel homePage, ContactUsPageModel contactUsPage)
        {
            _homePage = homePage;
            _contactUsPage = contactUsPage;
        }


        [Given(@"I am on the QAWorks Site")]
        public void GivenIAmOnTheQAWorksSite()
        {
            _homePage.NavigateToPage();
        }

        [Given(@"I have navigated to the contact us page")]
        public void GivenIHaveNavigatedToTheContactUsPage()
        {
            _homePage.NavigateToContactUsPage();
        }

        [When(@"I send a request for more information with valid details")]
        public void WhenISendARequestForMoreInformationWithValidDetails(Table contactDetailsTable)
        {
            _contactUsPage.SendContactDetails(contactDetailsTable.CreateInstance<ContactDetails>());
        }

        [Then(@"the contact request should be sent successfully")]
        public void ThenTheContactRequestShouldBeSentSuccessfully()
        {
            Assert.IsTrue(_contactUsPage.ContactDetailsWereSentSuccessfully());
            _contactUsPage.Close();
        }

       [When(@"I attempt to send a request for more information without a name")]
        public void WhenIAttemptToSendARequestForMoreInformationWithoutAName(Table contactDetailsTable)
        {
            _contactUsPage.SendContactDetails(contactDetailsTable.CreateInstance<ContactDetails>());
        }

        [Then(@"I should be informed that I must provide my name")]
        public void ThenIShouldBeInformedThatIMustProvideMyName()
        {
            Assert.IsTrue(_contactUsPage.MandatoryNameValidationMessageIsDisplayed());
            _contactUsPage.Close();
        }

        [When(@"I attempt to send a request for more information without an email address")]
        public void WhenIAttemptToSendARequestForMoreInformationWithoutAnEmailAddress(Table contactDetailsTable)
        {
            _contactUsPage.SendContactDetails(contactDetailsTable.CreateInstance<ContactDetails>());
        }

        [Then(@"I should be informed that I must provide an email address")]
        public void ThenIShouldBeInformedThatIMustProvideAnEmailAddress()
        {
            Assert.IsTrue(_contactUsPage.MandatoryEmailValidationMessageIsDisplayed());
            _contactUsPage.Close();
        }

        [When(@"I attempt to send a request for more information without a message")]
        public void WhenIAttemptToSendARequestForMoreInformationWithoutAMessage(Table contactDetailsTable)
        {
            _contactUsPage.SendContactDetails(contactDetailsTable.CreateInstance<ContactDetails>());
        }

        [Then(@"I should be informed that I must enter a message")]
        public void ThenIShouldBeInformedThatIMustEnterAMessage()
        {
            Assert.IsTrue(_contactUsPage.MandatoryMessageValidationMessageIsDisplayed());
            _contactUsPage.Close();
        }
        [When(@"I attempt to send a request for more information with an invalid email address")]
        public void WhenIAttemptToSendARequestForMoreInformationWithAnInvalidEmailAddress(Table contactDetailsTable)
        {
            _contactUsPage.SendContactDetails(contactDetailsTable.CreateInstance<ContactDetails>());
        }

        [Then(@"I should be informed that I must provide a valid email address")]
        public void ThenIShouldBeInformedThatIMustProvideAValidEmailAddress()
        {
            Assert.IsTrue(_contactUsPage.InvalidEmailAddressValidationMessageIsDisplayed());
            _contactUsPage.Close();
        }
    }
}
