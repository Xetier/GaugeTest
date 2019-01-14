using Gauge.CSharp.Lib.Attribute;
using FluentAssertions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace GaugeTest.Steps
{
    class DuckSteps
    {
        IWebDriver _driver;

        [BeforeSuite]
        public void Initialize()
        {
            _driver = new ChromeDriver();
        }

        [Step("Go to <url>")]
        public void GoToDuckDuckGo(string url)
        {
            Console.WriteLine(url);
            _driver.Navigate().GoToUrl(url);
        }

        [Step("Click to search Field")]
        public void ClickToSearchField()
        {
            _driver.FindElement(By.Id("search_form_input_homepage")).SendKeys("c#");
        }

        [Step("Click to button search")]
        public void ClickToButtonSearch()
        {
            _driver.FindElement(By.Id("search_button_homepage")).Click();
        }

        [Step("Click first link")]
        public void ClickFirstLink()
        {
            _driver.FindElement(By.LinkText("https://docs.microsoft.com/en-us/dotnet/csharp/")).Click();
        }

        [Step("Check title text <expectedT> exist")]
        public void CheckTitleTextCSharpGuideExist(string expectedT)
        {
            _driver.FindElement(By.Id("c-guide")).Text.Should().Be(expectedT);
            //Console.WriteLine(_driver.FindElement(By.Id("c-guide")).Text);
        }

        [AfterSuite]
        public void AfterSuite()
        {
            _driver?.Quit();
        }
    }
}
