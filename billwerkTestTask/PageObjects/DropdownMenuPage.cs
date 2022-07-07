using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace billwerkTestTask.PageObjects
{
    public class DropdownMenuPage : Form
    {
        private IComboBox SelectCountry => ElementFactory.GetComboBox(
            By.XPath("//div[@rel-title='Select Country']//select"), "Select country");

        public DropdownMenuPage() : base(By.XPath("//h1[text()='DropDown Menu']"),
            "DropDown Menu")
        { }

        public void ExpandCountryDropdownList()
        {
            SelectCountry.Click();
        }

        public List<string> GetCountries()
        {
            return SelectCountry.Values.ToList();
        }
    }
}