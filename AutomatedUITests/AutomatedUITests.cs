﻿using OpenQA.Selenium;
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
        public void UITest_CheckMicrosoftHomePage()
        {
            _driver.Navigate().GoToUrl("https://www.microsoft.com/cs-cz/");

            Assert.Equal("Microsoft – cloud, počítače, aplikace a hry", _driver.Title);
            Assert.Contains("Co je nového", _driver.PageSource);
        }
    }
}
