using Aquality.Selenium.Browsers;
using billwerkTestTask.Helpers;
using billwerkTestTask.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace billwerkTestTask.Steps
{
    [Binding]
    public sealed class GlobalSQASteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly DropdownMenuPage _dropdownMenuPage;

        public GlobalSQASteps(ScenarioContext scenarioContext, DropdownMenuPage dropdownMenuPage)
        {
            _scenarioContext = scenarioContext;
            _dropdownMenuPage = dropdownMenuPage;
        }

        [Given(@"the GlobalSQA page is opened")]
        public void OpenGlobalSQAPage()
        {
            BrowserHelper.OpenPage((Browser)_scenarioContext["browserInstance"],
                ConfigHelper.GetConfigProperties("projectDomain"));
        }

        [When(@"I click the select country dropdown")]
        public void ClickSelectCountryDropdown()
        {
            _dropdownMenuPage.ExpandCountryDropdownList();
        }

        [Then(@"the dropdown list contains '(\d+)' countries")]
        public void CheckExpectedNumberOfCountries(string expectedNumber)
        {
            var actualNumber = _dropdownMenuPage.GetCountries().Count.ToString();

            Assert.IsTrue(expectedNumber == actualNumber,
                $"Expected number of countries is {expectedNumber} but actual is {actualNumber}");
        }
    }
}