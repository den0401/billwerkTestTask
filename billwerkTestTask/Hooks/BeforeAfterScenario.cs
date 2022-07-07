using Aquality.Selenium.Browsers;
using TechTalk.SpecFlow;

namespace billwerkTestTask.Hooks
{
    [Binding]
    public sealed class BeforeAfterScenario
    {
        private readonly ScenarioContext _scenarioContext;

        public BeforeAfterScenario(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var browser = AqualityServices.Browser;
            browser.Maximize();

            _scenarioContext.Add("browserInstance", browser);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (AqualityServices.IsBrowserStarted)
            {
                AqualityServices.Browser.Quit();
            }
        }
    }
}