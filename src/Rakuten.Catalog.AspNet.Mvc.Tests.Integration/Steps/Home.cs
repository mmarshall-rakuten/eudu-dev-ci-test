
namespace Rakuten.Catalog.AspNet.Mvc.Tests.Integration
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;

    using TechTalk.SpecFlow;    
    
    [Binding]
    public class Home
    {
        private const string ScenarioContextKey = "IWebDriver";

        [Given(@"I have navigated to the website")]
        public void GivenIHaveNavigatedToTheWebsite()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--log-level=3");
            chromeOptions.AddArgument("--lang=en-US");

            IWebDriver webDriver = new ChromeDriver(chromeOptions);

            webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            webDriver.Navigate().GoToUrl("http://191.235.185.238/");

            ScenarioContext.Current.Add(ScenarioContextKey, webDriver);
        }

        [Then(@"I want to see the version number")]
        public void ThenIWantToSeeTheVersionNumber()
        {
            var webDriver = ScenarioContext.Current.Get<IWebDriver>(ScenarioContextKey);

            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            IWebElement footer = wait.Until(
                ExpectedConditions.ElementIsVisible(By.CssSelector("footer > p")));

            Assert.IsNotNull(footer.Text);

            webDriver.Dispose();
        }

    }
}
