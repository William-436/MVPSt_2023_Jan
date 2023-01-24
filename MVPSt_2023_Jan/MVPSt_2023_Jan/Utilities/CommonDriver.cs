using OpenQA.Selenium;

namespace MVPSt_2023_Jan.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        //[SetUp]
        //[OneTimeSetUp]
        //public void LoginSteps()
        //{
        //    // open Chrome browser because of using OpenQA.Selenium.Chrome; statement at top of code
        //    driver = new ChromeDriver();
        //    Console.WriteLine("**Starting Onboarding portal script from CommonDriver file");

        //    // login page (TYSPortalPage) object initialization and definition
        //    TYSPortalPage tysportalPageObj = new TYSPortalPage();
        //    tysportalPageObj.SigninActions(driver);

        //    // check if user has logged in successfully by finding Sign Out button at top right-hand corner of screen
        //    IWebElement buttonLabel = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

        //    Assert.That(buttonLabel.Text == "Sign Out", "Failed to Login successfully");
        //}

        //[TearDown]
        //[OneTimeTearDown]
        public void CloseTestRun()
        {
            Console.WriteLine("**Exiting/Ending Onboarding portal script from CommonDriver file");
            // close browser
            driver.Close();
            driver.Quit();
        }
    }
}
