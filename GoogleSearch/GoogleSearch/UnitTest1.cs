using OpenQA.Selenium.Chrome;

namespace GoogleSearch
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System;

    [TestFixture]
    public class UnitTest1
    {
        public string Expect = "Google";
        public string Actual = "Hello";
        private readonly IWebDriver _driver = new ChromeDriver();

        [Test]
        public void OpenPage()
        {
            _driver.Navigate().GoToUrl("http://www.google.com");
        }

        [Test]
        public void TypeInSearch()
        {
            string item = "Banana";
            _driver.FindElement(By.XPath("//*[@id='lst-ib']")).SendKeys(item);
            _driver.FindElement(By.XPath(".//*[@id='sblsbb']/button")).Click();
            _driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(2));
            Actual = _driver.Title;
            Console.WriteLine("Actual Page Title is " + Actual);
            Assert.IsTrue(Expect == Actual);
        }

        [Test]
        public void GetPageTitile()
        {
            int a = 1;
            int b = 1;

            Assert.IsTrue(a == b);
        }

        [OneTimeTearDown]
        public void Close()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}