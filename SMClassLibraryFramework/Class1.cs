using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using AutomationDemo;


namespace WebDriver_CSharp_Example
{


    [TestFixture]
    public class Chrome_Sample_test
    {
        private IWebDriver driver;
        public string homeURL;
        

        [Test(Description = "Check SauceLabs Homepage for Login Link")]
        public void Login_is_on_home_page()
        {

            var i = 100;
           
            homeURL = "https://www.SauceLabs.com";
            driver.Navigate().GoToUrl(homeURL);
            WebDriverWait wait = new WebDriverWait(driver,
System.TimeSpan.FromSeconds(15));
            wait.Until(driver =>
driver.FindElement(By.XPath("//a[@href='https://app.saucelabs.com/login']")));
            IWebElement element =
driver.FindElement(By.XPath("//a[@href='https://app.saucelabs.com/login']"));
            Assert.AreEqual("Sign in", element.GetAttribute("text"));

            // how to  add another dll to project and access its classess and method via the object
            Browsers myAD = new Browsers();
            myAD.smtest();

        }


        [TearDown]
        public void TearDownTest()
        {
            driver.Close();
        }


        [SetUp]
        public void SetupTest()
        {
            homeURL = "http://SauceLabs.com";
            driver = new ChromeDriver();
            //GitHub Test- Check if file and line shows

        }


    }


}

