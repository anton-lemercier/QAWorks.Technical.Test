using QAWorks.Selenium.Framework;
using QAWorks.Selenium.Framework.Helpers;
using QAWorks.Website.SmokeTests.DataModels;

namespace QAWorks.Website.SmokeTests.PageModels
{
    /// <summary>
    /// Represents a model of the QAWorks Contact Us page to facilitate communication between the test scenarios and the web driver
    /// </summary>
    public sealed class ContactUsPageModel
    {
        private readonly IBrowserDriver _driver;

        private const string NameBoxElementId = "ctl00_MainContent_NameBox";
        private const string EmailBoxElementId = "ctl00_MainContent_EmailBox";
        private const string MessageBoxElementId = "ctl00_MainContent_MessageBox";
        private const string SendButtonElementId = "ctl00_MainContent_SendButton";
        private const string MandatoryNameValidationMessageElementId = "ctl00_MainContent_rfvName";
        private const string MandatoryNameValidationMessageText = "Your name is required";
        private const string MandatoryEmailValidationMessageElementId = "ctl00_MainContent_rfvEmailAddress";
        private const string MandatoryEmailValidationMessageText = "An Email address is required";
        private const string MandatoryMessageValidationMessageElementId = "ctl00_MainContent_rfvMessage";
        private const string MandatoryMessageValidationMessageText = "Please type your message";
        private const string InvalidEmailValidationMessageElementId = "ctl00_MainContent_revEmailAddress";
        private const string InvalidEmailValidationMessageText = "Invalid Email Address";

        public ContactUsPageModel(IBrowserDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToPage()
        {
            _driver.NavigateToUrl(Settings.GetConfigValue("ContactUsPageUrl"));
        }
        public void SendContactDetails(ContactDetails contactDetails)
        {
            EnterName(contactDetails.Name);
            EnterEmail(contactDetails.Email);
            EnterMessage(contactDetails.Message);

            SubmitContactForm();
        }
        public void EnterName(string name)
        {
            _driver.PopulateInput(NameBoxElementId, name);
        }
        public void EnterEmail(string email)
        {
            _driver.PopulateInput(EmailBoxElementId, email);
        }
        public void EnterMessage(string message)
        {
            _driver.PopulateInput(MessageBoxElementId, message);
        }
        public void SubmitContactForm()
        {
            _driver.ClickElementById(SendButtonElementId);
        }
       public void Close()
        {
            _driver.CloseBrowser();
        }

        public bool ContactDetailsWereSentSuccessfully()
        {
            var name = _driver.GetElementInnerHtmlById(NameBoxElementId);
            var email = _driver.GetElementInnerHtmlById(EmailBoxElementId);
            var message = _driver.GetElementInnerHtmlById(MessageBoxElementId);

            return string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(email) && string.IsNullOrWhiteSpace(message);
        }

        public bool MandatoryNameValidationMessageIsDisplayed()
        {
            return _driver.GetElementInnerHtmlById(MandatoryNameValidationMessageElementId) == MandatoryNameValidationMessageText;
        }

        public bool MandatoryEmailValidationMessageIsDisplayed()
        {
            return _driver.GetElementInnerHtmlById(MandatoryEmailValidationMessageElementId) == MandatoryEmailValidationMessageText;
        }

        public bool MandatoryMessageValidationMessageIsDisplayed()
        {
            return _driver.GetElementInnerHtmlById(MandatoryMessageValidationMessageElementId) == MandatoryMessageValidationMessageText;
        }

        public bool InvalidEmailAddressValidationMessageIsDisplayed()
        {
            return _driver.GetElementInnerHtmlById(InvalidEmailValidationMessageElementId) == InvalidEmailValidationMessageText;
        }
    }
}
