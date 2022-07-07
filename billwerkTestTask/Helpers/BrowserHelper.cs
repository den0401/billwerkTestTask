using Aquality.Selenium.Browsers;

namespace billwerkTestTask.Helpers
{
    public static class BrowserHelper
    {
        public static void OpenPage(Browser browser, string url)
        {
            browser.GoTo(url);
        }
    }
}