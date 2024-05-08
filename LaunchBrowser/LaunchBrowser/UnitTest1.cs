using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LaunchBrowser
{
    public class Tests
    {
        IWebDriver driver;

       [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
                                  
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.google.com");

           // driver.FindElement(By.Id("q")).Click();

            Assert.Pass();
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
