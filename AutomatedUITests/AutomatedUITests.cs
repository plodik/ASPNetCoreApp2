using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AutomatedUITests
{
    public class AutomatedUITests : IDisposable
    {
        private readonly IWebDriver _driver;
        public AutomatedUITests()
        {
            _driver = new ChromeDriver();
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        [Fact]
        public void Create_WhenExecuted_ReturnsCreateView()
        {
            _driver.Navigate()
                .GoToUrl("https://localhost:44311/Home/Privacy");

            Assert.Equal("Privacy Policy - ASPNETCoreTest1", _driver.Title);
            Assert.Contains("Use this page to detail your site's privacy policy", _driver.PageSource);

            // comment added 11:05
            // second comment...
            // third comment...
        }
    }
}
