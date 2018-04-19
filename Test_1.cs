using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;

namespace AutoTest
{
    [TestFixture]
    public class Test
    {
        public static IWebDriver browser;

        IWebElement element;
        IWebElement element1;
        IWebElement breadcrumbs;
        IWebElement IsTestElementPresent;
        IWebElement nasos;
        IWebElement element2;
        IWebElement Lipstick;
        IWebElement Sort;
        IWebElement Price;
        IWebElement LowPriceElement;


        [OneTimeSetUp] // вызывается перед началом запуска всех тестов
        public void OneTimeSetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--ignore-certificate-errors");
            options.AddArguments("--ignore-ssl-errors");





        }

        //[OneTimeTearDown] //вызывается после завершения всех тестов
        public void OneTimeTearDown()
        {
            browser.Quit();

        }

        [SetUp] // вызывается перед каждым тестом
        public void SetUp()
        {
            browser = new ChromeDriver();
            browser.Manage().Window.Maximize();
            browser.Navigate().GoToUrl("https://www.google.com");

        }

        [TearDown] // вызывается после каждого теста
        public void TearDown()
        {
            browser.Quit(); // ТУТ 
        }

        [Test]
        public void TEST_1()
        {

            IWebElement SearchInput = browser.FindElement(By.Id("lst-ib"));
            //IWebElement element;
            SearchInput.SendKeys("hotline" + Keys.Enter);
            element = browser.FindElement(By.LinkText("Hotline - сравнить цены в интернет-магазинах Украины"));
            element.Click();
            Assert.AreEqual("Hotline - сравнить цены в интернет-магазинах Украины", browser.Title);




        }

        [Test]
        public void TEST_2()
        {
            browser.Navigate().GoToUrl("https://hotline.ua");
            IWebElement SearchClick = browser.FindElement(By.XPath("//body[@id='page-index']/header/div/div/div/div/div/div[2]/div/div[3]/div/div/span[2]"));
            SearchClick.Click();
            //IWebElement rus = browser.FindElement(By.XPath("//[@id='page-index']/header/div[1]/div/div/div[1]/div/div[2]/div/div[3]/div/div/span[1]"));
            //IWebElement urk = browser.FindElement(By.XPath("html/body/header/div[1]/div/div/div[1]/div/div[2]/div/div[3]/div/div/span[2]"));
            //Assert.IsTrue(rus != browser.FindElement(By.XPath("//body[@id='page-index']/header/div/div/div/div/div/div[2]/div/div[3]/div/div/span[2]"));






        }
        [Test]
        public void TEST_3()
        {
            browser.Navigate().GoToUrl("https://hotline.ua");
            IWebElement SearchClick = browser.FindElement(By.XPath("//body[@id='page-index']/div/div/div[2]/aside/nav/ul/li[5]/a"));
            SearchClick.Click();
            element1 = browser.FindElement(By.LinkText("Насос"));
            element1.Click();
            //breadcrumbs= browser.FindElement(By.Id("//[@id='page-index']/div[1]/div[1]/div[2]/aside/nav/ul/li[5]/a")); 
            //Assert.AreEqual(true, browser.FindElement(By.Id("//[@id='page-index']/div[1]/div[1]/div[2]/aside/nav/ul/li[5]/a")));
            //breadcrumbs = browser.FindElement(By.CssSelector("div.guide-section.guide-men"));

            bool IsTestElementPresent(IWebDriver driver)
            {
                try
                {
                    driver.FindElement(By.CssSelector("div.guide-section.guide-men"));
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }

        }
        [Test]
        public void TEST_4()
        {
            browser.Navigate().GoToUrl("https://hotline.ua");
            IWebElement SearchClick = browser.FindElement(By.XPath("//body[@id='page-index']/div/div/div[2]/aside/nav/ul/li[5]/a"));
            SearchClick.Click();
            element1 = browser.FindElement(By.ClassName("bricks-box"));
            element1.Click();
            nasos = browser.FindElement(By.XPath("//a[contains(@href, '/dacha_sad/nasosy-vodosnabzheniya/389584/')]"));
            nasos.Click();
            element2 = browser.FindElement(By.XPath("//body[@id='page-catalog']/div[2]/div/div/aside/div/div[3]/div/div[6]/div[2]/div/div/input[3"));
            element2.SendKeys("5000" + Keys.Enter);
        }



        [Test]
        public void TEST_5()
        {
            browser.Navigate().GoToUrl("https://hotline.ua");
            IWebElement Parfumi = browser.FindElement(By.XPath("//body[@id='page-index']/div[1]/div[1]/div[2]/aside/nav/ul/li[14]/a"));
            Parfumi.Click();
            Lipstick = browser.FindElement(By.XPath("//html/body/div[1]/div[1]/div/div[4]/ul/li[1]/div/a/span[2]/span[1]"));
            Lipstick.Click();
            Sort = browser.FindElement(By.CssSelector("select[name=sort]"));
            Sort.Click();
            Price = browser.FindElement(By.XPath("//div[@id='catalog-products']/div/div/div[3]/ul/li/selec"));
            Price.Click();
            LowPriceElement = browser.FindElement(By.PartialLinkText("по убыванию цен"));
            Assert.IsTrue(LowPriceElement == browser.FindElement(By.PartialLinkText("по убыванию цен")));



        }
    }






    }



