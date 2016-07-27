
namespace GoogleSearch
{
    using System;
    using System.Threading;
    using NUnit.Framework;
    using NUnit.Framework.Internal;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    [TestFixture]
    public class UnitTest1
    {
        string expect = "Google";
        string actual = null;
        IWebDriver driver = new ChromeDriver();
        [Test]
        public void OpenPage()
        {
 
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [Test]
        public void TypeInSearch()
        {
            string item = "Banana";
            driver.FindElement(By.XPath("//*[@id='lst-ib']")).SendKeys(item);
            driver.FindElement(By.XPath(".//*[@id='sblsbb']/button")).Click();
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(2));
            actual = driver.Title;
            Console.WriteLine("Actual Page Title is " + actual);
            Assert.IsTrue(expect == actual);
        }

        [Test]
        public void GetPageTitile()
        {

            Assert.IsTrue(1 == 1);

        }

        [TestFixtureTearDown]
        public void Close()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
