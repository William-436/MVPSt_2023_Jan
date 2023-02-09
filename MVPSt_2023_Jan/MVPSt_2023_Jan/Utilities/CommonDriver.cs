using MVPSt_2023_Jan.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MVPSt_2023_Jan.Utilities
{
    [Binding]
    public class CommonDriver
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public static void SetupDriver()
        //public void SetupDriver()
        {
            Console.WriteLine("**Starting Onboarding portal script from CommonDriver");

        // open Chrome browser
            driver = new ChromeDriver();
        }

        public void SignIntoTRSPortal()
        {
            // define Pages and Objects
            TYSPortalPage tysportalPageObj;
            //HomePage homePageObj;

            // initialize page objects
            tysportalPageObj = new TYSPortalPage();
            //homePageObj = new HomePage();

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

        public void CloseTestRun()
        {
            Console.WriteLine("**Exiting/Ending Onboarding portal script from CommonDriver");

            // close browser
            driver.Close();
            driver.Quit();
        }
    }
}
