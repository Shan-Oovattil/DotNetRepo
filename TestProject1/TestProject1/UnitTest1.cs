using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestProject1
{
    public class Tests
    {
        private IWebDriver _driver;

        [SetUp]
        public void Initialize()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [Test]
        [Ignore("Ignore a test")]
        [Description("This is a basic demo")]
        public void Test1()
        {
            //_driver.Navigate().GoToUrl("https://www/google.com");
            _driver.Url = ("https://www.google.com");

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            //wait.Until(ExpectedConditions.ElementExists(By.Id("id")));

            IWebElement seachBox = _driver.FindElement(By.XPath("//div//textarea[@id='APjFqb']"));
            seachBox.SendKeys("Testing");

            Thread.Sleep(2000);

            seachBox.SendKeys(Keys.Enter);

            Thread.Sleep(2000);

            Assert.Pass();
        }

        [Test]
        [Ignore("Ignore a test")]
        [Description("This is the demo of Navigate")]
        public void Test2() 
        {
            _driver.Navigate().GoToUrl("https://demoqa.com");

            _driver.FindElement(By.XPath(".//*[@id='menu-item-374']/a")).Click();
            _driver.Navigate().Back();
            _driver.Navigate().Forward();
            _driver.Navigate().Refresh();
            _driver.Close();
        }

        [Test]
        [Ignore("Ignore this testcase")]
        [Description("This is the demo of FindElements")]
        public void Test3()
        {
            _driver.Url = "https://www.lambdatest.com";

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //storing the number of links in list
            IList<IWebElement> links = _driver.FindElements(By.TagName("a"));

            //storing the size of the links
            int i = links.Count;

            //Printing the size of the string
            Console.WriteLine(i);

            foreach(IWebElement link in links)
            {
                Console.WriteLine(link.Text);
            }  
        }

        [Test]
        [Ignore("Not to Run")]
        [Description("This is the demo of Radio Button")]
        public void Test4()
        {
            _driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement rad1 = _driver.FindElement(By.XPath("//input[@value='radio2']"));
            rad1.Click();
            
            
           Thread.Sleep(2000);
        }

        [Test]
        [Ignore("Ignore for other Test to execute")]
        [Description("This is to select all the Radio Button one by one and Select all CheckBoxes")]
        public void Test5()
        {
            _driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IList<IWebElement> radioButtons = _driver.FindElements(By.XPath("//input[@type='radio']"));

            foreach (IWebElement radioBtn in radioButtons)
            {
                radioBtn.Click();
                Thread.Sleep(2000);
            }
            Thread.Sleep(2000);

            IList<IWebElement> checkboxes = _driver.FindElements(By.XPath("//input[@type='checkbox']"));

            foreach(IWebElement checkbox in checkboxes) 
            {
                checkbox.Click();
                Thread.Sleep(2000);
            }
            Thread.Sleep(2000);
        }

        [Test]
        [Ignore("Ignore")]
        [Description("This is the demo of DropDown")]
        public void Test6()
        {
            _driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            SelectElement selectElement = new SelectElement(_driver.FindElement(By.Id("dropdown-class-example")));
            
            selectElement.SelectByText("Option1");
            Thread.Sleep(3000);

            selectElement.SelectByIndex(0);
            Thread.Sleep(3000);
            selectElement.SelectByIndex(1);
            Thread.Sleep(3000);
            selectElement.SelectByIndex(2);
            Thread.Sleep(3000);

            selectElement.SelectByValue("option1");
            Thread.Sleep(3000);
        }

        [Test]
        [Ignore("just ignore")]
        [Description("This is the demo of Dropdown Element's Select using Options tag")]
        public void Test7()
        {
            _driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            SelectElement selectElement = new SelectElement(_driver.FindElement(By.Id("dropdown-class-example")));

            IList<IWebElement> selectElements = selectElement.Options;

            int countOfSelectElements = selectElements.Count;

            Console.WriteLine("Count of Select Elements=" + countOfSelectElements);

            foreach(IWebElement element in selectElements)
            {
                Console.WriteLine(element.Text);
            }
            Thread.Sleep(3000);            
        }

        [Test]
        [Description("This is the demo of Dynamic Web Table")]
        public void Test8()
        {
            String strRowData = "";

            _driver.Url = "https://en.wikipedia.org/wiki/Programming_languages_used_in_most_popular_websites";
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement elmTable = _driver.FindElement(By.XPath("//table[@class='wikitable sortable jquery-tablesorter']"));

            List<IWebElement> lstElementTr = new List<IWebElement>(elmTable.FindElements(By.TagName("tr")));
                        
            foreach (var elementTr in lstElementTr)
            {
                List<IWebElement> lstElementTd = new List<IWebElement>(elementTr.FindElements(By.TagName("td")));

                if(lstElementTd.Count > 0)
                {
                    foreach(var elementTd in  lstElementTd) 
                    {
                        strRowData += elementTd.Text + "\t\t\t";
                    }
                }
                else
                {
                    Console.WriteLine("This is Header Row");
                    Console.WriteLine(elementTr.Text+"\t\t\t");
                }
                Console.WriteLine(strRowData);
                strRowData = string.Empty;
            }
            Console.WriteLine("");

        }


        [TearDown]
        public void CloseBrowser() 
        {
            _driver.Quit();
        }


    }
}