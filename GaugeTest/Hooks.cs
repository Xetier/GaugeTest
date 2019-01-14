using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaugeTest
{
    public class Hooks
    {
        public static IWebDriver _driver;

        public Hooks()
        {
            _driver = new ChromeDriver();

        }

        public static IWebDriver WebDriver { get; }

        [AfterScenario]
        public void AfterScenario()
        {

        }
        [AfterSuite]
        public void AfterSuite()
        {

        }
        [BeforeScenario]
        public void BeforeScenario()
        {

        }
        [BeforeSuite]
        public void Initialize()
        {

        }
    }
}
