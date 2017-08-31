namespace QAWorks.Selenium.Framework
{
    public interface IBrowserDriver
    {
        void OpenBrowser();
        void CloseBrowser();
        void NavigateToUrl(string url);
        void PopulateInput(string id, string input);
        void ClickElementById(string id);
        void ClickElementByXpath(string xpath);
        string GetElementInnerHtmlById(string id, int pause = 0);
    }
}