using MVPSt_2023_Jan.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MVPSt_2023_Jan.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        // Nunit Hooks
        //[SetUp]
        //[OneTimeSetUp]
        public void SetupDriver()
        {
            Console.WriteLine("**Starting Onboarding portal script from CommonDriver");
            // open Chrome browser because of using OpenQA.Selenium.Chrome; statement at top of code
            driver = new ChromeDriver();
        }

        public void SignIntoTRSPortal()
        {
            // define Pages and Objects
            TYSPortalPage tysportalPageObj;
            HomePage homePageObj;

            // initialize objects
            tysportalPageObj = new TYSPortalPage();
            homePageObj = new HomePage();

            // sign in and check returned boolean value to see if successful
            if (tysportalPageObj.SigninActions() == true)
            {
                Console.WriteLine("Successfully Signed into Onboarding portal");
            }
            else
            {
                Console.WriteLine("Failed to Sign into Onboarding portal");
            }
        }

        //[TearDown]
        //[OneTimeTearDown]
        public void CloseTestRun()
        {
            Console.WriteLine("**Exiting/Ending Onboarding portal script from CommonDriver");
            // close browser
            driver.Close();
            driver.Quit();
        }
    }
}
