using NUnit.Framework;
using OpenQA.Selenium;
using MVPSt_2023_Jan.Utilities;
using static MVPSt_2023_Jan.Utilities.CommonDriver;


namespace MVPSt_2023_Jan.Pages
{
    public class TYSPortalPage
    {
        //public void SigninActions()
        public bool SigninActions()
        {
            Console.WriteLine("Start login from TYSPortalPage");
            driver.Manage().Window.Maximize();
            // launch Trade Your Skills portal & wait for the Sign In link to be clickable
            driver.Navigate().GoToUrl("http://localhost:5000");
            // wait for page to load and Sign In link to be clickable
            Wait.WaitForElementToBeClickable("XPath", "//*[@id=\"home\"]/div/div/div[1]/div/a", 4);

            try
            {
                // identify Sign In link and click on it
                IWebElement signinLink = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
                signinLink.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Failed to launch Trade Your Skills portal page", ex.Message);
            }
            // wait for email textbox to exist
            Wait.WaitForElementToExist("Name", "email", 1);
            // find Email address textbox and enter valid Email address
            IWebElement emailTextbox = driver.FindElement(By.Name("email"));
            emailTextbox.SendKeys("wbugan@aol.com");

            // identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
            passwordTextbox.SendKeys("Intport");

            // click login button
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            // wait for the Home page to load by looking for Sign Out button
            Wait.WaitForElementToExist("XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button", 4);

            IWebElement buttonLabel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
            // if button label is Sign Out, then set variable to (or return) true, otherwise false
            if (buttonLabel.Text == "Sign Out")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}